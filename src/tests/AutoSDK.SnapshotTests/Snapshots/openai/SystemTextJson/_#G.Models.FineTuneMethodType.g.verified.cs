//HintName: G.Models.FineTuneMethodType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of method. Is either `supervised`, `dpo`, or `reinforcement`.
    /// </summary>
    public enum FineTuneMethodType
    {
        /// <summary>
        /// 
        /// </summary>
        Dpo,
        /// <summary>
        /// 
        /// </summary>
        Reinforcement,
        /// <summary>
        /// 
        /// </summary>
        Supervised,
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
                FineTuneMethodType.Dpo => "dpo",
                FineTuneMethodType.Reinforcement => "reinforcement",
                FineTuneMethodType.Supervised => "supervised",
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
                "dpo" => FineTuneMethodType.Dpo,
                "reinforcement" => FineTuneMethodType.Reinforcement,
                "supervised" => FineTuneMethodType.Supervised,
                _ => null,
            };
        }
    }
}