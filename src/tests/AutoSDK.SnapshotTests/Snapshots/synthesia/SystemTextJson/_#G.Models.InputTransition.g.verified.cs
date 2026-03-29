//HintName: G.Models.InputTransition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public enum InputTransition
    {
        /// <summary>
        /// 
        /// </summary>
        Fade,
        /// <summary>
        /// 
        /// </summary>
        Fadeblack,
        /// <summary>
        /// 
        /// </summary>
        Fadescale,
        /// <summary>
        /// 
        /// </summary>
        Fadewhite,
        /// <summary>
        /// 
        /// </summary>
        Jumpcut,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Slidedown,
        /// <summary>
        /// 
        /// </summary>
        Slideleft,
        /// <summary>
        /// 
        /// </summary>
        Slideoverdown,
        /// <summary>
        /// 
        /// </summary>
        Slideoverleft,
        /// <summary>
        /// 
        /// </summary>
        Slideoverright,
        /// <summary>
        /// 
        /// </summary>
        Slideoverup,
        /// <summary>
        /// 
        /// </summary>
        Slideright,
        /// <summary>
        /// 
        /// </summary>
        Slideup,
        /// <summary>
        /// 
        /// </summary>
        Wipedown,
        /// <summary>
        /// 
        /// </summary>
        Wipeleft,
        /// <summary>
        /// 
        /// </summary>
        Wiperight,
        /// <summary>
        /// 
        /// </summary>
        Wipeup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputTransitionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputTransition value)
        {
            return value switch
            {
                InputTransition.Fade => "fade",
                InputTransition.Fadeblack => "fadeblack",
                InputTransition.Fadescale => "fadescale",
                InputTransition.Fadewhite => "fadewhite",
                InputTransition.Jumpcut => "jumpcut",
                InputTransition.None => "none",
                InputTransition.Slidedown => "slidedown",
                InputTransition.Slideleft => "slideleft",
                InputTransition.Slideoverdown => "slideoverdown",
                InputTransition.Slideoverleft => "slideoverleft",
                InputTransition.Slideoverright => "slideoverright",
                InputTransition.Slideoverup => "slideoverup",
                InputTransition.Slideright => "slideright",
                InputTransition.Slideup => "slideup",
                InputTransition.Wipedown => "wipedown",
                InputTransition.Wipeleft => "wipeleft",
                InputTransition.Wiperight => "wiperight",
                InputTransition.Wipeup => "wipeup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputTransition? ToEnum(string value)
        {
            return value switch
            {
                "fade" => InputTransition.Fade,
                "fadeblack" => InputTransition.Fadeblack,
                "fadescale" => InputTransition.Fadescale,
                "fadewhite" => InputTransition.Fadewhite,
                "jumpcut" => InputTransition.Jumpcut,
                "none" => InputTransition.None,
                "slidedown" => InputTransition.Slidedown,
                "slideleft" => InputTransition.Slideleft,
                "slideoverdown" => InputTransition.Slideoverdown,
                "slideoverleft" => InputTransition.Slideoverleft,
                "slideoverright" => InputTransition.Slideoverright,
                "slideoverup" => InputTransition.Slideoverup,
                "slideright" => InputTransition.Slideright,
                "slideup" => InputTransition.Slideup,
                "wipedown" => InputTransition.Wipedown,
                "wipeleft" => InputTransition.Wipeleft,
                "wiperight" => InputTransition.Wiperight,
                "wipeup" => InputTransition.Wipeup,
                _ => null,
            };
        }
    }
}