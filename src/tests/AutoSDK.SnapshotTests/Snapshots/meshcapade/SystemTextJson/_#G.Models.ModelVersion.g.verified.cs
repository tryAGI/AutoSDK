//HintName: G.Models.ModelVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Smplh,
        /// <summary>
        /// 
        /// </summary>
        Smplx,
        /// <summary>
        /// 
        /// </summary>
        Supr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVersion value)
        {
            return value switch
            {
                ModelVersion.Smplh => "SMPLH",
                ModelVersion.Smplx => "SMPLX",
                ModelVersion.Supr => "SUPR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVersion? ToEnum(string value)
        {
            return value switch
            {
                "SMPLH" => ModelVersion.Smplh,
                "SMPLX" => ModelVersion.Smplx,
                "SUPR" => ModelVersion.Supr,
                _ => null,
            };
        }
    }
}