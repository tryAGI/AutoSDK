//HintName: G.Models.ClassifierFTModelOutObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: model
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClassifierFTModelOutObject
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
    public static class ClassifierFTModelOutObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierFTModelOutObject value)
        {
            return value switch
            {
                ClassifierFTModelOutObject.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifierFTModelOutObject? ToEnum(string value)
        {
            return value switch
            {
                "model" => ClassifierFTModelOutObject.Model,
                _ => null,
            };
        }
    }
}