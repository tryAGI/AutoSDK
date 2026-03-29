//HintName: G.Models.BaseResponsesResultObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseResponsesResultObject
    {
        /// <summary>
        /// 
        /// </summary>
        Response,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseResponsesResultObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseResponsesResultObject value)
        {
            return value switch
            {
                BaseResponsesResultObject.Response => "response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseResponsesResultObject? ToEnum(string value)
        {
            return value switch
            {
                "response" => BaseResponsesResultObject.Response,
                _ => null,
            };
        }
    }
}