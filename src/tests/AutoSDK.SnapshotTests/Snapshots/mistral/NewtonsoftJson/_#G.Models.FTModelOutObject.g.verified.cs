//HintName: G.Models.FTModelOutObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: model
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FTModelOutObject
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
    public static class FTModelOutObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FTModelOutObject value)
        {
            return value switch
            {
                FTModelOutObject.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FTModelOutObject? ToEnum(string value)
        {
            return value switch
            {
                "model" => FTModelOutObject.Model,
                _ => null,
            };
        }
    }
}