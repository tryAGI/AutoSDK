//HintName: G.Models.CreateVideoToVideoRequestDiscriminatorModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateVideoToVideoRequestDiscriminatorModel
    {
        /// <summary>
        /// 
        /// </summary>
        Gen4Aleph,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToVideoRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateVideoToVideoRequestDiscriminatorModel.Gen4Aleph => "gen4_aleph",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "gen4_aleph" => CreateVideoToVideoRequestDiscriminatorModel.Gen4Aleph,
                _ => null,
            };
        }
    }
}