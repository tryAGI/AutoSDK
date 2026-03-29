//HintName: G.Models.AgentRequestAmbientSound.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If set, will add ambient environment sound to the call to make experience more realistic. Currently supports the following options:<br/>
    /// - `coffee-shop`: Coffee shop ambience with people chatting in background. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/coffee-shop.wav)<br/>
    /// - `convention-hall`: Convention hall ambience, with some echo and people chatting in background. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/convention-hall.wav)<br/>
    /// - `summer-outdoor`: Summer outdoor ambience with cicada chirping. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/summer-outdoor.wav)<br/>
    /// - `mountain-outdoor`: Mountain outdoor ambience with birds singing. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/mountain-outdoor.wav)<br/>
    /// - `static-noise`: Constant static noise. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/static-noise.wav)<br/>
    /// - `call-center`: Call center work noise. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/call-center.wav)<br/>
    /// Set to `null` to remove ambient sound from this agent.
    /// </summary>
    public enum AgentRequestAmbientSound
    {
        /// <summary>
        /// Call center work noise. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/call-center.wav)
        /// </summary>
        CallCenter,
        /// <summary>
        /// Coffee shop ambience with people chatting in background. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/coffee-shop.wav)
        /// </summary>
        CoffeeShop,
        /// <summary>
        /// Convention hall ambience, with some echo and people chatting in background. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/convention-hall.wav)
        /// </summary>
        ConventionHall,
        /// <summary>
        /// Mountain outdoor ambience with birds singing. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/mountain-outdoor.wav)
        /// </summary>
        MountainOutdoor,
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// Constant static noise. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/static-noise.wav)
        /// </summary>
        StaticNoise,
        /// <summary>
        /// Summer outdoor ambience with cicada chirping. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/summer-outdoor.wav)
        /// </summary>
        SummerOutdoor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRequestAmbientSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRequestAmbientSound value)
        {
            return value switch
            {
                AgentRequestAmbientSound.CallCenter => "call-center",
                AgentRequestAmbientSound.CoffeeShop => "coffee-shop",
                AgentRequestAmbientSound.ConventionHall => "convention-hall",
                AgentRequestAmbientSound.MountainOutdoor => "mountain-outdoor",
                AgentRequestAmbientSound.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                AgentRequestAmbientSound.StaticNoise => "static-noise",
                AgentRequestAmbientSound.SummerOutdoor => "summer-outdoor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRequestAmbientSound? ToEnum(string value)
        {
            return value switch
            {
                "call-center" => AgentRequestAmbientSound.CallCenter,
                "coffee-shop" => AgentRequestAmbientSound.CoffeeShop,
                "convention-hall" => AgentRequestAmbientSound.ConventionHall,
                "mountain-outdoor" => AgentRequestAmbientSound.MountainOutdoor,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => AgentRequestAmbientSound.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "static-noise" => AgentRequestAmbientSound.StaticNoise,
                "summer-outdoor" => AgentRequestAmbientSound.SummerOutdoor,
                _ => null,
            };
        }
    }
}