//HintName: G.Models.CreatePathwayResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePathwayResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePathwayResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePathwayResponseStatus value)
        {
            return value switch
            {
                CreatePathwayResponseStatus.Error => "error",
                CreatePathwayResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePathwayResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreatePathwayResponseStatus.Error,
                "success" => CreatePathwayResponseStatus.Success,
                _ => null,
            };
        }
    }
}