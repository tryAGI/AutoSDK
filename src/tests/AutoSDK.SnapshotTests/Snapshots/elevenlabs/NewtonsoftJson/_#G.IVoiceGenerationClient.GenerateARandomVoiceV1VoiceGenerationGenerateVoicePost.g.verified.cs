//HintName: G.IVoiceGenerationClient.GenerateARandomVoiceV1VoiceGenerationGenerateVoicePost.g.cs
#nullable enable

namespace G
{
    public partial interface IVoiceGenerationClient
    {
        /// <summary>
        /// Generate A Random Voice<br/>
        /// Generate a random voice based on parameters. This method returns a generated_voice_id in the response header, and a sample of the voice in the body. If you like the generated voice call /v1/voice-generation/create-voice with the generated_voice_id to create the voice.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.HTTPValidationError> GenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAsync(
            global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate A Random Voice<br/>
        /// Generate a random voice based on parameters. This method returns a generated_voice_id in the response header, and a sample of the voice in the body. If you like the generated voice call /v1/voice-generation/create-voice with the generated_voice_id to create the voice.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="gender">
        /// Category code corresponding to the gender of the generated voice. Possible values: female, male.
        /// </param>
        /// <param name="accent">
        /// Category code corresponding to the accent of the generated voice. Possible values: american, british, african, australian, indian.
        /// </param>
        /// <param name="age">
        /// Category code corresponding to the age of the generated voice. Possible values: young, middle_aged, old.
        /// </param>
        /// <param name="accentStrength">
        /// The strength of the accent of the generated voice. Has to be between 0.3 and 2.0.
        /// </param>
        /// <param name="text">
        /// Text to generate, text length has to be between 100 and 1000.<br/>
        /// Example: Every act of kindness, no matter how small, carries value and can make a difference, as no gesture of goodwill is ever wasted.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.HTTPValidationError> GenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAsync(
            global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender gender,
            string accent,
            global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAge age,
            double accentStrength,
            string text,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}