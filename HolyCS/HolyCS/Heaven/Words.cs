namespace HolyCS.Heaven
{
    public class Words
    {
        static string Text;

        public Words(string s) => Text = s;
        public new string ToString() => Text;

        public static implicit operator Words(string v) => new Words(v);
        public static explicit operator string(Words v) => Text;
    }
}
