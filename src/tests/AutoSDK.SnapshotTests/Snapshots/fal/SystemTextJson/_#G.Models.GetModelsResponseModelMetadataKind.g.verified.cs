//HintName: G.Models.GetModelsResponseModelMetadataKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model kind - inference or training (optional)
    /// </summary>
    public enum GetModelsResponseModelMetadataKind
    {
        /// <summary>
        /// 
        /// </summary>
        Inference,
        /// <summary>
        /// 
        /// </summary>
        Training,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsResponseModelMetadataKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsResponseModelMetadataKind value)
        {
            return value switch
            {
                GetModelsResponseModelMetadataKind.Inference => "inference",
                GetModelsResponseModelMetadataKind.Training => "training",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsResponseModelMetadataKind? ToEnum(string value)
        {
            return value switch
            {
                "inference" => GetModelsResponseModelMetadataKind.Inference,
                "training" => GetModelsResponseModelMetadataKind.Training,
                _ => null,
            };
        }
    }
}