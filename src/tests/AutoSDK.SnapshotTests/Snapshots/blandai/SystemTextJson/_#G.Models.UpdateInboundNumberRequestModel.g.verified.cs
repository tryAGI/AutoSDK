//HintName: G.Models.UpdateInboundNumberRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateInboundNumberRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Base,
        /// <summary>
        /// 
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateInboundNumberRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateInboundNumberRequestModel value)
        {
            return value switch
            {
                UpdateInboundNumberRequestModel.Base => "base",
                UpdateInboundNumberRequestModel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateInboundNumberRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "base" => UpdateInboundNumberRequestModel.Base,
                "turbo" => UpdateInboundNumberRequestModel.Turbo,
                _ => null,
            };
        }
    }
}