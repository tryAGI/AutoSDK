//HintName: G.Models.ImageModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The image model used for the generation<br/>
    /// Default Value: photon-1
    /// </summary>
    public enum ImageModel
    {
        /// <summary>
        /// 
        /// </summary>
        Photon1,
        /// <summary>
        /// 
        /// </summary>
        PhotonFlash1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageModel value)
        {
            return value switch
            {
                ImageModel.Photon1 => "photon-1",
                ImageModel.PhotonFlash1 => "photon-flash-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageModel? ToEnum(string value)
        {
            return value switch
            {
                "photon-1" => ImageModel.Photon1,
                "photon-flash-1" => ImageModel.PhotonFlash1,
                _ => null,
            };
        }
    }
}