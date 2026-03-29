//HintName: G.Models.ExportFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExportFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fbx")]
        Fbx,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="glb")]
        Glb,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="obj")]
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