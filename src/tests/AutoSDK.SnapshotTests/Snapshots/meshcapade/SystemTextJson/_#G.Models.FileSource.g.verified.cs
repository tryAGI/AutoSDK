//HintName: G.Models.FileSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FileSource
    {
        /// <summary>
        /// 
        /// </summary>
        Generated,
        /// <summary>
        /// 
        /// </summary>
        Meshcapade,
        /// <summary>
        /// 
        /// </summary>
        OnPremPlaceholder,
        /// <summary>
        /// 
        /// </summary>
        Upload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileSource value)
        {
            return value switch
            {
                FileSource.Generated => "GENERATED",
                FileSource.Meshcapade => "MESHCAPADE",
                FileSource.OnPremPlaceholder => "ON_PREM_PLACEHOLDER",
                FileSource.Upload => "UPLOAD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileSource? ToEnum(string value)
        {
            return value switch
            {
                "GENERATED" => FileSource.Generated,
                "MESHCAPADE" => FileSource.Meshcapade,
                "ON_PREM_PLACEHOLDER" => FileSource.OnPremPlaceholder,
                "UPLOAD" => FileSource.Upload,
                _ => null,
            };
        }
    }
}