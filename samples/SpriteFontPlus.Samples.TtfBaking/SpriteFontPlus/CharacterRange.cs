namespace SpriteFontPlus.Samples.TtfBaking.MonoGame.SpriteFontPlus
{
    public struct CharacterRange
    {
        public static readonly CharacterRange BasicLatin = new CharacterRange((char) 0x0020, (char) 0x007F);

        public static readonly CharacterRange Latin1Supplement =
            new CharacterRange((char) 0x00A0, (char) 0x00FF);

        public static readonly CharacterRange LatinExtendedA =
            new CharacterRange((char) 0x0100, (char) 0x017F);

        public static readonly CharacterRange LatinExtendedB =
            new CharacterRange((char) 0x0180, (char) 0x024F);

        public static readonly CharacterRange Chinese =
            new CharacterRange((char) 0x4E00, (char) 0x9FA5);

        public static readonly CharacterRange ChineseSupplement =
            new CharacterRange((char) 0x9FA6, (char) 0x9FEF);

        public static readonly CharacterRange ChineseSymbol0 = new CharacterRange(0x3002); // 。 句号
        public static readonly CharacterRange ChineseSymbol1 = new CharacterRange(0xFF1F); // ？ 问好
        public static readonly CharacterRange ChineseSymbol2 = new CharacterRange(0xFF01); // ！ 感叹号
        public static readonly CharacterRange ChineseSymbol3 = new CharacterRange(0xFF0C); // ， 逗号
        public static readonly CharacterRange ChineseSymbol4 = new CharacterRange(0x3001); // 、 顿号
        public static readonly CharacterRange ChineseSymbol5 = new CharacterRange(0xFF1B); // ； 分号
        public static readonly CharacterRange ChineseSymbol6 = new CharacterRange(0xFF1A); // ： 冒号
        public static readonly CharacterRange ChineseSymbol7 = new CharacterRange(0x300C); // 「 引号
        public static readonly CharacterRange ChineseSymbol8 = new CharacterRange(0x300D); // 」
        public static readonly CharacterRange ChineseSymbol9 = new CharacterRange(0x300E); // 『 引号
        public static readonly CharacterRange ChineseSymbol10 = new CharacterRange(0x300F); // 』
        public static readonly CharacterRange ChineseSymbol11 = new CharacterRange(0x2018); // ‘ 引号
        public static readonly CharacterRange ChineseSymbol12 = new CharacterRange(0x2019); // ’
        public static readonly CharacterRange ChineseSymbol13 = new CharacterRange(0x201C); // “ 引号
        public static readonly CharacterRange ChineseSymbol14 = new CharacterRange(0x201D); // ”
        public static readonly CharacterRange ChineseSymbol15 = new CharacterRange(0xFF08); // （ 括号
        public static readonly CharacterRange ChineseSymbol16 = new CharacterRange(0xFF09); // ）
        public static readonly CharacterRange ChineseSymbol17 = new CharacterRange(0x3014); // 〔 括号
        public static readonly CharacterRange ChineseSymbol18 = new CharacterRange(0x3015); // 〕
        public static readonly CharacterRange ChineseSymbol19 = new CharacterRange(0x3010); // 【 括号
        public static readonly CharacterRange ChineseSymbol20 = new CharacterRange(0x3011); // 】
        public static readonly CharacterRange ChineseSymbol21 = new CharacterRange(0x2014); // — 破折号
        public static readonly CharacterRange ChineseSymbol22 = new CharacterRange(0x2026); // … 省略号
        public static readonly CharacterRange ChineseSymbol23 = new CharacterRange(0x2013); // – 连接号
        public static readonly CharacterRange ChineseSymbol24 = new CharacterRange(0xFF0E); // ． 间隔号
        public static readonly CharacterRange ChineseSymbol25 = new CharacterRange(0x300A); // 《 书名号
        public static readonly CharacterRange ChineseSymbol26 = new CharacterRange(0x300B); // 》
        public static readonly CharacterRange ChineseSymbol27 = new CharacterRange(0x300A); // 〈 书名号
        public static readonly CharacterRange ChineseSymbol28 = new CharacterRange(0x300A); // 〉 

        public char Start { get; private set; }
        public char End { get; private set; }

        public CharacterRange(char start, char end)
        {
            Start = start;
            End = end;
        }

        public CharacterRange(int single) : this((char) single, (char) single)
        {
        }

        public CharacterRange(char single) : this(single, single)
        {
        }
    }
}