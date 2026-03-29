//HintName: G.Models.OAIModelsResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OAIModelsResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OAIModelsResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAIModelsResponseObject value)
        {
            return value switch
            {
                OAIModelsResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAIModelsResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => OAIModelsResponseObject.List,
                _ => null,
            };
        }
    }
}