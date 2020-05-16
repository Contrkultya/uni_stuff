<html>

<head>
    <link rel=stylesheet href='style.css' type='text/css'>
    <title>5 до 15</title>
</head>

<body>

    <div class="leftcol">
        <table>
            <tr>
                <td>Фамилия</td>
            </tr>
            @foreach($staff as $s)
                <tr>
                    <td> {{$s->FIO}}</td>
                </tr>
            @endforeach
        </table>

    </div>

    <div class="rightcol">
        <!--*******************Навигационное меню*******************-->
        <ul class="menu">
            <li><a href="/stage">Фамилии персон, имеющих стаж от 5 до 15 лет.</a></li>
            <li><a href="/coders">Фамилии и стаж людей с профессией Программист</a></li>
            <li><a href="/amount">Общее число резюме в базе</a></li>
            <li><a href="/professions">Профессии, представители которых имеются в резюме</a></li>
            <li><a href="/">Обратно</a></li>
        </ul>
    </div>
    <div class="footer">&copy; Copyright 2017</div>

</body>

</html>
