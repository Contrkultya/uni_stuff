<template>
    <v-data-table :headers="headers" :items="waybills" sort-by="ID" class="elevation-1">
        <template v-slot:top>
            <h1 class="ml-3">Накладные</h1>
            <v-dialog v-model="dialog" max-width="500px">
                <template v-slot:activator="{ on }">
                    <v-btn color="primary" dark class="mb-2 ml-2" v-on="on" tile>Добавить элемент</v-btn>
                </template>
                <v-card>
                    <v-card-title>
                        <span class="headline">Накладная</span>
                    </v-card-title>
                    <v-card-text>
                        <v-container>
                            <v-row>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.ID" label="ID накладной"></v-text-field>
                                </v-col>
                                <v-menu ref="menu" v-model="menu" :close-on-content-click="false" :return-value.sync="date" transition="scale-transition" offset-y min-width="290px">
                                    <template v-slot:activator="{ on }">
                                        <v-text-field v-model="date" label="Дата"  readonly v-on="on"></v-text-field>
                                    </template>
                                    <v-date-picker v-model="date" no-title scrollable>
                                        <v-spacer></v-spacer>
                                        <v-btn text color="primary" @click="menu = false">Cancel</v-btn>
                                        <v-btn text color="primary" @click="$refs.menu.save(date)">OK</v-btn>
                                    </v-date-picker>
                                </v-menu>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.number" label="Количество"></v-text-field>
                                </v-col>
                                <v-col class="d-flex" cols="12" sm="6">
                                    <v-select :items="dealers" id="sas" label="Поставщик" dense outlined></v-select>
                                </v-col>
                            </v-row>
                        </v-container>
                    </v-card-text>

                    <v-card-actions>
                        <v-spacer></v-spacer>
                        <v-btn color="blue darken-1" text @click="close">Cancel</v-btn>
                        <v-btn color="blue darken-1" text @click="save">Save</v-btn>
                    </v-card-actions>
                </v-card>
            </v-dialog>
        </template>
        <template v-slot:item.action="{ item }">
            <v-icon small @click="editItem(item)">mdi-pencil-outline</v-icon>
            <v-icon class="ml-5" small @click="deleteItem(item)">mdi-delete</v-icon>
        </template>
        <template v-slot:no-data>
            <v-btn color="primary" @click="initialize">Перезагрузить</v-btn>
        </template>
    </v-data-table>
</template>

<script>
    import axios from 'axios';
    export default {
        name: "Waybills",
        data: () => ({
            dialog: false,
            headers: [
                {text: 'ID', align: 'left', value: 'ID'},
                {text: 'Дата', value: 'date'},
                {text: 'Количество', value: 'amount'},
                {text: 'Поставщик', value: 'dealer'},
                {text: 'Действия', value: 'action', sortable: false},
            ],
            waybills: [],
            dealers: [],
            editedIndex: -1,
            editedItem: {
                ID: '',
                number: 0,
                dealerID: 0,
            },
            defaultItem: {
                ID: '',
                number: 0,
                dealerID: 0,
            },
        }),

        computed: {
            formTitle() {
                return this.editedIndex === -1 ? 'New Item' : 'Edit Item'
            },
        },

        watch: {
            dialog(val) {
                val || this.close()
            },
        },

        created() {
            this.initialize()
        },

        methods: {
            initialize() {
                const rw = this;
                axios.get('http://localhost:5000/getInfo?table=dealers')
                    .then(function (res) {
                        let goodBills = [];
                        for (let i = 0; i < res.data.length; i++) {
                            let elem = res.data[i][0] +" : "+ res.data[i][1];
                            goodBills.push(elem);
                        }
                        rw.dealers = goodBills;
                    })
                    .catch(function (res) {
                        //handle error
                        console.log(res);
                    });
                axios.get('http://localhost:5000/getInfo?table=' + window.location.href.split('/')[3])
                    .then(function (res) {
                        let goodBills = [];
                        for (let i = 0; i < res.data.length; i++) {
                            let dealer = '';
                            for(let j = 0; j < rw.dealers.length; j++) {
                                console.log(rw.dealers[j].split(':')[0]);
                                console.log(res.data[i][3]);
                                if (res.data[i][3] == rw.dealers[j].split(':')[0]) {
                                    dealer = rw.dealers[j].split(':')[1];
                                }
                            }
                            let elem = {
                                ID: res.data[i][0],
                                date: res.data[i][1],
                                amount: res.data[i][2],
                                dealerID: res.data[i][3],
                                dealer: dealer
                            };
                            goodBills.push(elem);
                        }
                        rw.waybills = goodBills;
                    })
                    .catch(function (res) {
                        //handle error
                        console.log(res);
                    });
            },

            editItem(item) {
                this.editedIndex = this.reports.indexOf(item);
                this.editedItem = Object.assign({}, item);
                this.dialog = true;
            },

            deleteItem(item) {
                const rw = this;
                const index = this.reports.indexOf(item);
                let result = confirm("Удалить элемент " + (this.reports[index].ID) + '?');
                if (result) {
                    axios({
                        method: 'post',
                        url: 'http://localhost:5000/removeElement',
                        data: {
                            table: 'reports',
                            id: rw.reports[index].ID
                        },
                    }).then(function (response) {
                        location.reload();
                    })
                        .catch(function (response) {
                            //handle error
                            console.log(response);
                        })
                }
            },

            close() {
                this.dialog = false;
                setTimeout(() => {
                    this.editedItem = Object.assign({}, this.defaultItem);
                    this.editedIndex = -1;
                }, 300)
            },

            save() {
                let nameCheck = false;
                let productCheck = false;
                let priceCheck = false;
                if (document.getElementById('name').value) {
                    nameCheck = true;
                }
                if (document.getElementById('prod').value) {
                    productCheck = true;
                }
                if (!isNaN(document.getElementById('price').value)) {
                    priceCheck = true;
                }


                if (priceCheck && nameCheck && productCheck) {
                    if (document.getElementById('id').value == 'ID') {
                        addItem();
                    } else {
                        updateItem();
                    }
                }


                function addItem() {
                    axios({
                        method: 'post',
                        url: 'http://localhost:5000/addElement',
                        data: {
                            table: 'dealers',
                            cols: 'products, name, retail_price',
                            values: "('" + document.getElementById('prod').value + "', '"
                                + document.getElementById('name').value + "','" + document.getElementById('price').value + "')"
                        },
                    }).then(function (response) {
                        location.reload();
                    })
                        .catch(function (response) {
                            //handle error
                            console.log(response);
                        })
                }


                function updateItem() {
                    axios({
                        method: 'post',
                        url: 'http://localhost:5000/updateElement',
                        data: {
                            table: 'dealers',
                            cols: 'products, name, retail_price',
                            id: document.getElementById('id').value,
                            values: "('" + document.getElementById('prod').value + "', '"
                                + document.getElementById('name').value + "','" + document.getElementById('price').value + "')"
                        },
                    }).then(function (response) {
                        location.reload();
                    })
                        .catch(function (response) {
                            //handle error
                            console.log(response);
                        })
                }

            },

        },
    }
</script>

<style scoped>

</style>
