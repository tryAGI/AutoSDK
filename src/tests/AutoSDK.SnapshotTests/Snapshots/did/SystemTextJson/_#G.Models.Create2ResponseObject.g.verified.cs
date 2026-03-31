//HintName: G.Models.Create2ResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An identifier of this scene
    /// </summary>
    public enum Create2ResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        Scene,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Create2ResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create2ResponseObject value)
        {
            return value switch
            {
                Create2ResponseObject.Scene => "scene",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create2ResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "scene" => Create2ResponseObject.Scene,
                _ => null,
            };
        }
    }
}