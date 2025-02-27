//HintName: G.Models.ModelVariant14.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelVariant14
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-2.0")]
        Claude20,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant14Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant14 value)
        {
            return value switch
            {
                ModelVariant14.Claude20 => "claude-2.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant14? ToEnum(string value)
        {
            return value switch
            {
                "claude-2.0" => ModelVariant14.Claude20,
                _ => null,
            };
        }
    }
}