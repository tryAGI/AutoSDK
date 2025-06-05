﻿//HintName: G.Models.InputAudioFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: wav
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputAudioFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wav")]
        Wav,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3")]
        Mp3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputAudioFormat value)
        {
            return value switch
            {
                InputAudioFormat.Wav => "wav",
                InputAudioFormat.Mp3 => "mp3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "wav" => InputAudioFormat.Wav,
                "mp3" => InputAudioFormat.Mp3,
                _ => null,
            };
        }
    }
}