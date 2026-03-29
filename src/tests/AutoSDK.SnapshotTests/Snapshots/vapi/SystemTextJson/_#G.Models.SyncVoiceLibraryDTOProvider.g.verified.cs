//HintName: G.Models.SyncVoiceLibraryDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SyncVoiceLibraryDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        x11labs,
        /// <summary>
        /// 
        /// </summary>
        Azure,
        /// <summary>
        /// 
        /// </summary>
        Cartesia,
        /// <summary>
        /// 
        /// </summary>
        CustomVoice,
        /// <summary>
        /// 
        /// </summary>
        Deepgram,
        /// <summary>
        /// 
        /// </summary>
        Hume,
        /// <summary>
        /// 
        /// </summary>
        Inworld,
        /// <summary>
        /// 
        /// </summary>
        Lmnt,
        /// <summary>
        /// 
        /// </summary>
        Minimax,
        /// <summary>
        /// 
        /// </summary>
        Neuphonic,
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        Orpheus,
        /// <summary>
        /// 
        /// </summary>
        Playht,
        /// <summary>
        /// 
        /// </summary>
        RimeAi,
        /// <summary>
        /// 
        /// </summary>
        Sesame,
        /// <summary>
        /// 
        /// </summary>
        SmallestAi,
        /// <summary>
        /// 
        /// </summary>
        Tavus,
        /// <summary>
        /// 
        /// </summary>
        Vapi,
        /// <summary>
        /// 
        /// </summary>
        Wellsaid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SyncVoiceLibraryDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SyncVoiceLibraryDTOProvider value)
        {
            return value switch
            {
                SyncVoiceLibraryDTOProvider.x11labs => "11labs",
                SyncVoiceLibraryDTOProvider.Azure => "azure",
                SyncVoiceLibraryDTOProvider.Cartesia => "cartesia",
                SyncVoiceLibraryDTOProvider.CustomVoice => "custom-voice",
                SyncVoiceLibraryDTOProvider.Deepgram => "deepgram",
                SyncVoiceLibraryDTOProvider.Hume => "hume",
                SyncVoiceLibraryDTOProvider.Inworld => "inworld",
                SyncVoiceLibraryDTOProvider.Lmnt => "lmnt",
                SyncVoiceLibraryDTOProvider.Minimax => "minimax",
                SyncVoiceLibraryDTOProvider.Neuphonic => "neuphonic",
                SyncVoiceLibraryDTOProvider.Openai => "openai",
                SyncVoiceLibraryDTOProvider.Orpheus => "orpheus",
                SyncVoiceLibraryDTOProvider.Playht => "playht",
                SyncVoiceLibraryDTOProvider.RimeAi => "rime-ai",
                SyncVoiceLibraryDTOProvider.Sesame => "sesame",
                SyncVoiceLibraryDTOProvider.SmallestAi => "smallest-ai",
                SyncVoiceLibraryDTOProvider.Tavus => "tavus",
                SyncVoiceLibraryDTOProvider.Vapi => "vapi",
                SyncVoiceLibraryDTOProvider.Wellsaid => "wellsaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SyncVoiceLibraryDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "11labs" => SyncVoiceLibraryDTOProvider.x11labs,
                "azure" => SyncVoiceLibraryDTOProvider.Azure,
                "cartesia" => SyncVoiceLibraryDTOProvider.Cartesia,
                "custom-voice" => SyncVoiceLibraryDTOProvider.CustomVoice,
                "deepgram" => SyncVoiceLibraryDTOProvider.Deepgram,
                "hume" => SyncVoiceLibraryDTOProvider.Hume,
                "inworld" => SyncVoiceLibraryDTOProvider.Inworld,
                "lmnt" => SyncVoiceLibraryDTOProvider.Lmnt,
                "minimax" => SyncVoiceLibraryDTOProvider.Minimax,
                "neuphonic" => SyncVoiceLibraryDTOProvider.Neuphonic,
                "openai" => SyncVoiceLibraryDTOProvider.Openai,
                "orpheus" => SyncVoiceLibraryDTOProvider.Orpheus,
                "playht" => SyncVoiceLibraryDTOProvider.Playht,
                "rime-ai" => SyncVoiceLibraryDTOProvider.RimeAi,
                "sesame" => SyncVoiceLibraryDTOProvider.Sesame,
                "smallest-ai" => SyncVoiceLibraryDTOProvider.SmallestAi,
                "tavus" => SyncVoiceLibraryDTOProvider.Tavus,
                "vapi" => SyncVoiceLibraryDTOProvider.Vapi,
                "wellsaid" => SyncVoiceLibraryDTOProvider.Wellsaid,
                _ => null,
            };
        }
    }
}