//HintName: G.Models.UnarchiveFTModelOutObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: model
    /// </summary>
    public enum UnarchiveFTModelOutObject
    {
        /// <summary>
        /// 
        /// </summary>
        Model,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnarchiveFTModelOutObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnarchiveFTModelOutObject value)
        {
            return value switch
            {
                UnarchiveFTModelOutObject.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnarchiveFTModelOutObject? ToEnum(string value)
        {
            return value switch
            {
                "model" => UnarchiveFTModelOutObject.Model,
                _ => null,
            };
        }
    }
}