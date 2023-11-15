import sqlite3


class Scientists:
    def __init__(self):
        self.con = sqlite3.connect("scapp.db")
        self.cur = self.con.cursor()
        self.cur.execute(
            "create table if not exists Scientists "
            "(ScId integer primary key not null, "
            "ScFIO text not null, "
            "ScDeg text not null, "
            "ScCountry text not null, "
            "ScOrg text not null) "
        )

    def __del__(self):
        self.con.close()

    def view_scientists(self):
        self.cur.execute("select * from Scientists")
        rows = self.cur.fetchall()
        return rows

    def create_scientist(self, sc_fio, sc_deg, sc_country, sc_org):
        self.cur.execute(
            f"insert into Scientists "
            f"values(NULL, '{sc_fio}', '{sc_deg}', '{sc_country}', '{sc_org}') "
        )
        self.con.commit()

    def delete_scientist(self, sc_id):
        self.cur.execute(
            f"delete from Scientists "
            f"where ScId = {sc_id} "
        )
        self.con.commit()

    def update_scientists(self, sc_id, sc_fio, sc_deg, sc_country, sc_org):
        self.cur.execute(
            f"update Scientists set "
            f"ScFIO = '{sc_fio}', ScDeg = '{sc_deg}', ScCountry = '{sc_country}', ScOrg = '{sc_org}' "
            f"where ScId = {sc_id} "
        )
        self.con.commit()

    def search_scientist_on_fio(self, search_text):
        self.cur.execute(
            f"select * from Scientists "
            f"where ScFio = '{search_text}' "
        )
        rows = self.cur.fetchall()
        return rows


class Conferences:
    def __init__(self):
        self.con = sqlite3.connect("scapp.db")
        self.cur = self.con.cursor()
        self.cur.execute(
            "create table if not exists Conferences "
            "(ConfId integer primary key not null, "
            "ConfName text not null, "
            "ConfDate text not null, "
            "ConfCountry text not null) "
        )

    def __del__(self):
        self.con.close()

    def view_conferences(self):
        self.cur.execute("select * from Conferences")
        rows = self.cur.fetchall()
        return rows

    def create_conference(self, conf_name, conf_date, conf_country):
        self.cur.execute(
            f"insert into Conferences "
            f"values(NULL, '{conf_name}', '{conf_date}', '{conf_country}') "
        )
        self.con.commit()

    def delete_conference(self, conf_id):
        self.cur.execute(
            f"delete from Conferences "
            f"where ConfId = {conf_id} "
        )
        self.con.commit()

    def update_conference(self, conf_id, conf_name, conf_date, conf_country):
        self.cur.execute(
            f"update Conferences set "
            f"ConfName = '{conf_name}', ConfDate = '{conf_date}', ConfCountry = '{conf_country}' "
            f"where ConfId = {conf_id} "
        )
        self.con.commit()

    def search_conferences_on_name(self, search_text):
        self.cur.execute(
            f"select * from Conferences "
            f"where ConfName = '{search_text}' "
        )
        rows = self.cur.fetchall()
        return rows


class Reports:
    def __init__(self):
        self.con = sqlite3.connect("scapp.db")
        self.cur = self.con.cursor()
        self.cur.execute(
            "create table if not exists Reports "
            "(RepId integer primary key not null, "
            "RepTheme text not null, "
            "RepAuthor integer references Scientists (ScId), "
            "RepConf integer references Conferences (ConfId)) "
        )

    def __del__(self):
        self.con.close()

    def view_reports(self):
        self.cur.execute(
            "select RepId, RepTheme, ScFIO, ScDeg, ScCountry, ScOrg, ConfName, ConfDate, ConfCountry from Reports R "
            "join Scientists S on R.RepAuthor = S.ScId "
            "join Conferences C on R.RepConf = C.ConfId "
        )
        rows = self.cur.fetchall()
        return rows

    def create_report(self, rep_theme, rep_author, rep_conf):
        self.cur.execute(
            f"insert into Reports "
            f"values(NULL, '{rep_theme}', '{rep_author}', '{rep_conf}' "
        )
        self.con.commit()

    def delete_report(self, rep_id):
        self.cur.execute(
            f"delete from Reports "
            f"where RepId = {rep_id} "
        )
        self.con.commit()

    def update_report(self, rep_id, rep_theme, rep_author, rep_conf):
        self.cur.execute(
            f"update Reports set "
            f"RepTheme = '{rep_theme}', RepAuthor = {rep_author}, RepConf = {rep_conf} "
            f"where RepId = {rep_id} "
        )
        self.con.commit()

    def search_reports_on_theme(self, search_text):
        self.cur.execute(
            f"select RepId, RepTheme, ScFIO, ScDeg, ScCountry, ScOrg, ConfName, ConfDate, ConfCountry from Reports R "
            f"join Scientists S on R.RepAuthor = S.ScId "
            f"join Conferences C on R.RepConf = C.ConfId "
            f"where RepTheme = '{search_text}' "
        )
        rows = self.cur.fetchall()
        return rows
