//HintName: G.Models.CreateSipRequestToolDTOVerb.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The SIP method to send.
    /// </summary>
    public enum CreateSipRequestToolDTOVerb
    {
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Message,
        /// <summary>
        /// 
        /// </summary>
        Notify,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSipRequestToolDTOVerbExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSipRequestToolDTOVerb value)
        {
            return value switch
            {
                CreateSipRequestToolDTOVerb.Info => "INFO",
                CreateSipRequestToolDTOVerb.Message => "MESSAGE",
                CreateSipRequestToolDTOVerb.Notify => "NOTIFY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSipRequestToolDTOVerb? ToEnum(string value)
        {
            return value switch
            {
                "INFO" => CreateSipRequestToolDTOVerb.Info,
                "MESSAGE" => CreateSipRequestToolDTOVerb.Message,
                "NOTIFY" => CreateSipRequestToolDTOVerb.Notify,
                _ => null,
            };
        }
    }
}