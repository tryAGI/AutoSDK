//HintName: G.Models.ModelInfoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Object type.<br/>
    /// For Models, this is always `"model"`.<br/>
    /// Default Value: model
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelInfoType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="model")]
        Model,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelInfoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelInfoType value)
        {
            return value switch
            {
                ModelInfoType.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelInfoType? ToEnum(string value)
        {
            return value switch
            {
                "model" => ModelInfoType.Model,
                _ => null,
            };
        }
    }
}