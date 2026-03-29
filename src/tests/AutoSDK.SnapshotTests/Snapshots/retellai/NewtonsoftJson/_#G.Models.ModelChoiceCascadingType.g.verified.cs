//HintName: G.Models.ModelChoiceCascadingType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of model choice
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelChoiceCascadingType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cascading")]
        Cascading,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelChoiceCascadingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelChoiceCascadingType value)
        {
            return value switch
            {
                ModelChoiceCascadingType.Cascading => "cascading",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelChoiceCascadingType? ToEnum(string value)
        {
            return value switch
            {
                "cascading" => ModelChoiceCascadingType.Cascading,
                _ => null,
            };
        }
    }
}