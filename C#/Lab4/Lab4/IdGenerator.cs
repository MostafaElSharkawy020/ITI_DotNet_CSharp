namespace Lab4
{
    static class IdGenerator
    {
        private static int Id = 0;
        public static int GenerateId()
        {
            return ++Id;
        }
    }
}
