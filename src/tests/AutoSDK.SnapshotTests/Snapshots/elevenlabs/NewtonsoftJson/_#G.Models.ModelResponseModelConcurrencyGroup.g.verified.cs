//HintName: G.Models.ModelResponseModelConcurrencyGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The concurrency group for the model.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelResponseModelConcurrencyGroup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="standard")]
        Standard,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="turbo")]
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelResponseModelConcurrencyGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelResponseModelConcurrencyGroup value)
        {
            return value switch
            {
                ModelResponseModelConcurrencyGroup.Standard => "standard",
                ModelResponseModelConcurrencyGroup.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelResponseModelConcurrencyGroup? ToEnum(string value)
        {
            return value switch
            {
                "standard" => ModelResponseModelConcurrencyGroup.Standard,
                "turbo" => ModelResponseModelConcurrencyGroup.Turbo,
                _ => null,
            };
        }
    }
}