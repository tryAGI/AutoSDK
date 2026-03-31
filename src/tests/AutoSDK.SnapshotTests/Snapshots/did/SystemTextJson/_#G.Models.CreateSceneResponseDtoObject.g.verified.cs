//HintName: G.Models.CreateSceneResponseDtoObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An identifier of this scene
    /// </summary>
    public enum CreateSceneResponseDtoObject
    {
        /// <summary>
        /// 
        /// </summary>
        Scene,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSceneResponseDtoObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSceneResponseDtoObject value)
        {
            return value switch
            {
                CreateSceneResponseDtoObject.Scene => "scene",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSceneResponseDtoObject? ToEnum(string value)
        {
            return value switch
            {
                "scene" => CreateSceneResponseDtoObject.Scene,
                _ => null,
            };
        }
    }
}