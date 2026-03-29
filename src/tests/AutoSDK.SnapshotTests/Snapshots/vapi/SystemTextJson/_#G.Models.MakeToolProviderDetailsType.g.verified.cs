//HintName: G.Models.MakeToolProviderDetailsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "make" for Make tool.
    /// </summary>
    public enum MakeToolProviderDetailsType
    {
        /// <summary>
        /// 
        /// </summary>
        Make,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MakeToolProviderDetailsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MakeToolProviderDetailsType value)
        {
            return value switch
            {
                MakeToolProviderDetailsType.Make => "make",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MakeToolProviderDetailsType? ToEnum(string value)
        {
            return value switch
            {
                "make" => MakeToolProviderDetailsType.Make,
                _ => null,
            };
        }
    }
}