//HintName: G.Models.ExportFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExportFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Fbx,
        /// <summary>
        /// 
        /// </summary>
        Glb,
        /// <summary>
        /// 
        /// </summary>
        Obj,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportFormat value)
        {
            return value switch
            {
                ExportFormat.Fbx => "fbx",
                ExportFormat.Glb => "glb",
                ExportFormat.Obj => "obj",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportFormat? ToEnum(string value)
        {
            return value switch
            {
                "fbx" => ExportFormat.Fbx,
                "glb" => ExportFormat.Glb,
                "obj" => ExportFormat.Obj,
                _ => null,
            };
        }
    }
}