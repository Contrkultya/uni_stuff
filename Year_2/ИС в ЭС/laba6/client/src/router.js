import Vue from 'vue';
import Router from 'vue-router';

import Login from "@/views/Login";
import Info from "@/views/Info";
import Dealers from "@/views/Dealers"
import Waybills from "@/views/Waybills";
import Products from "@/views/Products";
import Bills from "@/views/Bills";
import Reports from "@/views/Reports";
import Employees from "@/views/Employees";
import Sales from "@/views/Sales";

Vue.use(Router);

const router = new Router({
    routes: [
        {
            path: '*',
            redirect: '/info'
        },
        {
            path: '/info',
            name: 'Info',
            component: Info
        },
        {
            path: '/login',
            name: 'Login',
            component: Login
        },
        {
            path: '/dealers',
            name: 'Dealers',
            component: Dealers
        },
        {
            path: '/waybills',
            name: 'Waybills',
            component: Waybills
        },
        {
            path: '/products',
            name: 'Products',
            component: Products
        },
        {
            path: '/bills',
            name: 'Bills',
            component: Bills
        },
        {
            path: '/reports',
            name: 'Reports',
            component: Reports
        },
        {
            path: '/employees',
            name: 'Employees',
            component: Employees
        }
        ,
        {
            path: '/sales',
            name: 'Sales',
            component: Sales
        }


    ],
    mode: 'history'
});


export default router;
