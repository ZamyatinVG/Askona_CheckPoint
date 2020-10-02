namespace Askona_CheckPoint
{
    public static class Rights
    {
        public static bool p_user = false;
        public static bool p_staff = false;
    }

    public static class Status
    {
        public static string Initial = "исходный";
        public static string Changed = "изменено";
        public static string Approved = "утверждено";
        public static string ActiveInput = "активный (вход)";
        public static string ActiveOutput = "активный (выход)";
        public static string Completed = "завершено";
        public static string EntryAllowed = "въезд разрешен";
        public static string ShipmentCompleted = "отгрузка завершена";
    }
}
