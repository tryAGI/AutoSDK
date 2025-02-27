//HintName: G.Models.ModelVariant7.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Our previous most intelligent model
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-5-sonnet-20241022")]
        Claude35Sonnet20241022,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant7 value)
        {
            return value switch
            {
                ModelVariant7.Claude35Sonnet20241022 => "claude-3-5-sonnet-20241022",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant7? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-sonnet-20241022" => ModelVariant7.Claude35Sonnet20241022,
                _ => null,
            };
        }
    }
}