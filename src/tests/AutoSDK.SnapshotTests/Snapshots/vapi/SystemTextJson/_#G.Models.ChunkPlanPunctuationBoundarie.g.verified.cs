//HintName: G.Models.ChunkPlanPunctuationBoundarie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChunkPlanPunctuationBoundarie
    {
        /// <summary>
        /// 
        /// </summary>
        ArabicComma,
        /// <summary>
        /// 
        /// </summary>
        CjkComma,
        /// <summary>
        /// 
        /// </summary>
        CjkPeriod,
        /// <summary>
        /// 
        /// </summary>
        CloseParen,
        /// <summary>
        /// 
        /// </summary>
        Colon,
        /// <summary>
        /// 
        /// </summary>
        Comma,
        /// <summary>
        /// 
        /// </summary>
        DevanagariDanda,
        /// <summary>
        /// 
        /// </summary>
        DevanagariDoubleDanda,
        /// <summary>
        /// 
        /// </summary>
        DoublePipe,
        /// <summary>
        /// 
        /// </summary>
        Exclamation,
        /// <summary>
        /// 
        /// </summary>
        Period,
        /// <summary>
        /// 
        /// </summary>
        Pipe,
        /// <summary>
        /// 
        /// </summary>
        Question,
        /// <summary>
        /// 
        /// </summary>
        Semicolon,
        /// <summary>
        /// 
        /// </summary>
        UrduPeriod,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChunkPlanPunctuationBoundarieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChunkPlanPunctuationBoundarie value)
        {
            return value switch
            {
                ChunkPlanPunctuationBoundarie.ArabicComma => "arabic-comma",
                ChunkPlanPunctuationBoundarie.CjkComma => "cjk-comma",
                ChunkPlanPunctuationBoundarie.CjkPeriod => "cjk-period",
                ChunkPlanPunctuationBoundarie.CloseParen => "close-paren",
                ChunkPlanPunctuationBoundarie.Colon => "colon",
                ChunkPlanPunctuationBoundarie.Comma => "comma",
                ChunkPlanPunctuationBoundarie.DevanagariDanda => "devanagari-danda",
                ChunkPlanPunctuationBoundarie.DevanagariDoubleDanda => "devanagari-double-danda",
                ChunkPlanPunctuationBoundarie.DoublePipe => "double-pipe",
                ChunkPlanPunctuationBoundarie.Exclamation => "exclamation",
                ChunkPlanPunctuationBoundarie.Period => "period",
                ChunkPlanPunctuationBoundarie.Pipe => "pipe",
                ChunkPlanPunctuationBoundarie.Question => "question",
                ChunkPlanPunctuationBoundarie.Semicolon => "semicolon",
                ChunkPlanPunctuationBoundarie.UrduPeriod => "urdu-period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChunkPlanPunctuationBoundarie? ToEnum(string value)
        {
            return value switch
            {
                "arabic-comma" => ChunkPlanPunctuationBoundarie.ArabicComma,
                "cjk-comma" => ChunkPlanPunctuationBoundarie.CjkComma,
                "cjk-period" => ChunkPlanPunctuationBoundarie.CjkPeriod,
                "close-paren" => ChunkPlanPunctuationBoundarie.CloseParen,
                "colon" => ChunkPlanPunctuationBoundarie.Colon,
                "comma" => ChunkPlanPunctuationBoundarie.Comma,
                "devanagari-danda" => ChunkPlanPunctuationBoundarie.DevanagariDanda,
                "devanagari-double-danda" => ChunkPlanPunctuationBoundarie.DevanagariDoubleDanda,
                "double-pipe" => ChunkPlanPunctuationBoundarie.DoublePipe,
                "exclamation" => ChunkPlanPunctuationBoundarie.Exclamation,
                "period" => ChunkPlanPunctuationBoundarie.Period,
                "pipe" => ChunkPlanPunctuationBoundarie.Pipe,
                "question" => ChunkPlanPunctuationBoundarie.Question,
                "semicolon" => ChunkPlanPunctuationBoundarie.Semicolon,
                "urdu-period" => ChunkPlanPunctuationBoundarie.UrduPeriod,
                _ => null,
            };
        }
    }
}