from DBConnect import Scientists
from DBConnect import Conferences
from DBConnect import Reports

tab_sci = Scientists()
tab_conf = Conferences()
tab_rep = Reports()

is_run = True


def view_rows(out):
    for row in out:
        print(row)


def view_sci_command():
    view_rows(tab_sci.view_scientists())


def view_conf_command():
    view_rows(tab_conf.view_conferences())


def view_rep_command():
    view_rows(tab_rep.view_reports())


def add_edit_sci_command(comm):
    sc_fio = input('Введите ФИО ученого: ')
    sc_deg = input('Введите степень ученого: ')
    sc_country = input('Введите страну ученого: ')
    sc_org = input('Введите организацию ученого: ')

    if comm == 1:
        tab_sci.create_scientist(sc_fio, sc_deg, sc_country, sc_org)
    else:
        sc_id = int(input("Введите ID ученого для редактирования: "))
        tab_sci.update_scientists(sc_id, sc_fio, sc_deg, sc_country, sc_org)


def add_edit_conf_command(comm):
    conf_name = input("Введите название конференции: ")
    conf_date = input("Введите дату конференции: ")
    conf_country = input("Введите страну конференции: ")

    if comm == 1:
        tab_conf.create_conference(conf_name, conf_date, conf_country)
    else:
        conf_id = int(input("Введите ID конференции для редактирования: "))
        tab_conf.update_conference(conf_id, conf_name, conf_date, conf_country)


def add_report_command(comm):
    rep_theme = input("Введите тему доклада: ")
    rep_author = int(input("Введите ID автора(ученого): "))
    rep_conf = int(input("Введите ID конференции: "))

    if comm == 1:
        tab_rep.create_report(rep_theme, rep_author, rep_conf)
    else:
        rep_id = int(input("Введите ID доклада для редактирования: "))
        tab_rep.update_report(rep_id, rep_theme, rep_author, rep_conf)


def delete_sci_command():
    sc_id = int(input('Введите ID ученого для удаления: '))
    tab_sci.delete_scientist(sc_id)


def delete_conf_command():
    conf_id = int(input("Введите ID конференции для удаления: "))
    tab_conf.delete_conference(conf_id)


def delete_rep_command():
    rep_id = int(input("Введите ID доклада для удаления: "))
    tab_rep.delete_report(rep_id)


def search_command_sci():
    search_text = input("Введите текст: ")
    tab_sci.search_scientist_on_fio(search_text)


def search_command_conf():
    search_text = input("Введите текст: ")
    tab_conf.search_conferences_on_name(search_text)


def search_rep_command():
    search_text = input("Введите текст: ")
    tab_rep.search_reports_on_theme(search_text)


while is_run:
    command = input('Введите команду: ')

    if command == 'Ученые':
        view_sci_command()
    elif command == 'Конференции':
        view_conf_command()
    elif command == 'Доклады':
        view_rep_command()
    elif command == 'Добавить ученого':
        add_edit_sci_command(1)
    elif command == 'Добавить конференцию':
        add_edit_conf_command(1)
    elif command == 'Добавить доклад':
        add_report_command(1)
    elif command == 'Удалить ученого':
        delete_sci_command()
    elif command == 'Удалить конференцию':
        delete_conf_command()
    elif command == 'Удалить доклад':
        delete_rep_command()
    elif command == 'Обновить ученого':
        add_edit_sci_command(0)
    elif command == 'Обновить конференцию':
        add_edit_conf_command(0)
    elif command == 'Обновить доклад':
        add_report_command(0)
    elif command == 'Поиск ученого по ФИО':
        search_command_sci()
    elif command == 'Поиск конференции по названию':
        search_command_conf()
    elif command == 'Поиск доклада по теме':
        search_rep_command()
    elif command == 'Список команд':
        print(
            f'Ученые - вывод списка всех ученых\n'
            f'Конференции - вывод списка всех конференций\n'
            f'Доклады - вывод списка всех докладов\n'
            f'Добавить ученого\n'
            f'Добавить конференцию\n'
            f'Добавить доклад\n'
            f'Удалить ученого\n'
            f'Удалить конференцию\n'
            f'Удалить доклад\n'
            f'Обновить ученого\n'
            f'Обновить конференцию\n'
            f'Обновить доклад\n'
            f'Поиск ученого по ФИО\n'
            f'Поиск конференции по названию\n'
            f'Поиск доклада по теме'
        )
    elif command == 'Выйти':
        is_run = False
    else:
        print("Команда неккоректная. Введите команду 'Список команд' для просмотра всех команд")
    print()
