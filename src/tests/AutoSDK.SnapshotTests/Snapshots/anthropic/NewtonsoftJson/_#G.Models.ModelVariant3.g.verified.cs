//HintName: G.Models.ModelVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Our most intelligent model
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-7-sonnet-20250219")]
        Claude37Sonnet20250219,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant3 value)
        {
            return value switch
            {
                ModelVariant3.Claude37Sonnet20250219 => "claude-3-7-sonnet-20250219",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant3? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-7-sonnet-20250219" => ModelVariant3.Claude37Sonnet20250219,
                _ => null,
            };
        }
    }
}