//HintName: G.Models.FineTuneMethodType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of method. Is either `supervised` or `dpo`.
    /// </summary>
    public enum FineTuneMethodType
    {
        /// <summary>
        /// 
        /// </summary>
        Supervised,
        /// <summary>
        /// 
        /// </summary>
        Dpo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneMethodTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneMethodType value)
        {
            return value switch
            {
                FineTuneMethodType.Supervised => "supervised",
                FineTuneMethodType.Dpo => "dpo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneMethodType? ToEnum(string value)
        {
            return value switch
            {
                "supervised" => FineTuneMethodType.Supervised,
                "dpo" => FineTuneMethodType.Dpo,
                _ => null,
            };
        }
    }
}