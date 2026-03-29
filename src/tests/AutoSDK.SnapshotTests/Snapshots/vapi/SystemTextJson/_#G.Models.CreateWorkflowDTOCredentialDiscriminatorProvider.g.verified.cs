//HintName: G.Models.CreateWorkflowDTOCredentialDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWorkflowDTOCredentialDiscriminatorProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        AnthropicBedrock,
        /// <summary>
        /// 
        /// </summary>
        Anyscale,
        /// <summary>
        /// 
        /// </summary>
        AssemblyAi,
        /// <summary>
        /// 
        /// </summary>
        Azure,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        ByoSipTrunk,
        /// <summary>
        /// 
        /// </summary>
        Cartesia,
        /// <summary>
        /// 
        /// </summary>
        Cerebras,
        /// <summary>
        /// 
        /// </summary>
        Cloudflare,
        /// <summary>
        /// 
        /// </summary>
        CustomCredential,
        /// <summary>
        /// 
        /// </summary>
        CustomLlm,
        /// <summary>
        /// 
        /// </summary>
        DeepSeek,
        /// <summary>
        /// 
        /// </summary>
        Deepgram,
        /// <summary>
        /// 
        /// </summary>
        Deepinfra,
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Gcp,
        /// <summary>
        /// 
        /// </summary>
        GhlOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        Gladia,
        /// <summary>
        /// 
        /// </summary>
        Gohighlevel,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        GoogleCalendarOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        GoogleCalendarOauth2Client,
        /// <summary>
        /// 
        /// </summary>
        GoogleSheetsOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        Groq,
        /// <summary>
        /// 
        /// </summary>
        Hume,
        /// <summary>
        /// 
        /// </summary>
        InflectionAi,
        /// <summary>
        /// 
        /// </summary>
        Inworld,
        /// <summary>
        /// 
        /// </summary>
        Langfuse,
        /// <summary>
        /// 
        /// </summary>
        Lmnt,
        /// <summary>
        /// 
        /// </summary>
        Make,
        /// <summary>
        /// 
        /// </summary>
        Minimax,
        /// <summary>
        /// 
        /// </summary>
        Mistral,
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
        Openrouter,
        /// <summary>
        /// 
        /// </summary>
        PerplexityAi,
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
        Runpod,
        /// <summary>
        /// 
        /// </summary>
        S3,
        /// <summary>
        /// 
        /// </summary>
        SlackWebhook,
        /// <summary>
        /// 
        /// </summary>
        SlackOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        SmallestAi,
        /// <summary>
        /// 
        /// </summary>
        Soniox,
        /// <summary>
        /// 
        /// </summary>
        Speechmatics,
        /// <summary>
        /// 
        /// </summary>
        Supabase,
        /// <summary>
        /// 
        /// </summary>
        Tavus,
        /// <summary>
        /// 
        /// </summary>
        TogetherAi,
        /// <summary>
        /// 
        /// </summary>
        Trieve,
        /// <summary>
        /// 
        /// </summary>
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        Vonage,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
        /// <summary>
        /// 
        /// </summary>
        Wellsaid,
        /// <summary>
        /// 
        /// </summary>
        Xai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWorkflowDTOCredentialDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWorkflowDTOCredentialDiscriminatorProvider value)
        {
            return value switch
            {
                CreateWorkflowDTOCredentialDiscriminatorProvider.Anthropic => "anthropic",
                CreateWorkflowDTOCredentialDiscriminatorProvider.AnthropicBedrock => "anthropic-bedrock",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Anyscale => "anyscale",
                CreateWorkflowDTOCredentialDiscriminatorProvider.AssemblyAi => "assembly-ai",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Azure => "azure",
                CreateWorkflowDTOCredentialDiscriminatorProvider.AzureOpenai => "azure-openai",
                CreateWorkflowDTOCredentialDiscriminatorProvider.ByoSipTrunk => "byo-sip-trunk",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Cartesia => "cartesia",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Cerebras => "cerebras",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Cloudflare => "cloudflare",
                CreateWorkflowDTOCredentialDiscriminatorProvider.CustomCredential => "custom-credential",
                CreateWorkflowDTOCredentialDiscriminatorProvider.CustomLlm => "custom-llm",
                CreateWorkflowDTOCredentialDiscriminatorProvider.DeepSeek => "deep-seek",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Deepgram => "deepgram",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Deepinfra => "deepinfra",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Elevenlabs => "elevenlabs",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Email => "email",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Gcp => "gcp",
                CreateWorkflowDTOCredentialDiscriminatorProvider.GhlOauth2Authorization => "ghl.oauth2-authorization",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Gladia => "gladia",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Gohighlevel => "gohighlevel",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Google => "google",
                CreateWorkflowDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization => "google.calendar.oauth2-authorization",
                CreateWorkflowDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Client => "google.calendar.oauth2-client",
                CreateWorkflowDTOCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization => "google.sheets.oauth2-authorization",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Groq => "groq",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Hume => "hume",
                CreateWorkflowDTOCredentialDiscriminatorProvider.InflectionAi => "inflection-ai",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Inworld => "inworld",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Langfuse => "langfuse",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Lmnt => "lmnt",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Make => "make",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Minimax => "minimax",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Mistral => "mistral",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Neuphonic => "neuphonic",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Openai => "openai",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Openrouter => "openrouter",
                CreateWorkflowDTOCredentialDiscriminatorProvider.PerplexityAi => "perplexity-ai",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Playht => "playht",
                CreateWorkflowDTOCredentialDiscriminatorProvider.RimeAi => "rime-ai",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Runpod => "runpod",
                CreateWorkflowDTOCredentialDiscriminatorProvider.S3 => "s3",
                CreateWorkflowDTOCredentialDiscriminatorProvider.SlackWebhook => "slack-webhook",
                CreateWorkflowDTOCredentialDiscriminatorProvider.SlackOauth2Authorization => "slack.oauth2-authorization",
                CreateWorkflowDTOCredentialDiscriminatorProvider.SmallestAi => "smallest-ai",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Soniox => "soniox",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Speechmatics => "speechmatics",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Supabase => "supabase",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Tavus => "tavus",
                CreateWorkflowDTOCredentialDiscriminatorProvider.TogetherAi => "together-ai",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Trieve => "trieve",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Twilio => "twilio",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Vonage => "vonage",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Webhook => "webhook",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Wellsaid => "wellsaid",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWorkflowDTOCredentialDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => CreateWorkflowDTOCredentialDiscriminatorProvider.Anthropic,
                "anthropic-bedrock" => CreateWorkflowDTOCredentialDiscriminatorProvider.AnthropicBedrock,
                "anyscale" => CreateWorkflowDTOCredentialDiscriminatorProvider.Anyscale,
                "assembly-ai" => CreateWorkflowDTOCredentialDiscriminatorProvider.AssemblyAi,
                "azure" => CreateWorkflowDTOCredentialDiscriminatorProvider.Azure,
                "azure-openai" => CreateWorkflowDTOCredentialDiscriminatorProvider.AzureOpenai,
                "byo-sip-trunk" => CreateWorkflowDTOCredentialDiscriminatorProvider.ByoSipTrunk,
                "cartesia" => CreateWorkflowDTOCredentialDiscriminatorProvider.Cartesia,
                "cerebras" => CreateWorkflowDTOCredentialDiscriminatorProvider.Cerebras,
                "cloudflare" => CreateWorkflowDTOCredentialDiscriminatorProvider.Cloudflare,
                "custom-credential" => CreateWorkflowDTOCredentialDiscriminatorProvider.CustomCredential,
                "custom-llm" => CreateWorkflowDTOCredentialDiscriminatorProvider.CustomLlm,
                "deep-seek" => CreateWorkflowDTOCredentialDiscriminatorProvider.DeepSeek,
                "deepgram" => CreateWorkflowDTOCredentialDiscriminatorProvider.Deepgram,
                "deepinfra" => CreateWorkflowDTOCredentialDiscriminatorProvider.Deepinfra,
                "elevenlabs" => CreateWorkflowDTOCredentialDiscriminatorProvider.Elevenlabs,
                "email" => CreateWorkflowDTOCredentialDiscriminatorProvider.Email,
                "gcp" => CreateWorkflowDTOCredentialDiscriminatorProvider.Gcp,
                "ghl.oauth2-authorization" => CreateWorkflowDTOCredentialDiscriminatorProvider.GhlOauth2Authorization,
                "gladia" => CreateWorkflowDTOCredentialDiscriminatorProvider.Gladia,
                "gohighlevel" => CreateWorkflowDTOCredentialDiscriminatorProvider.Gohighlevel,
                "google" => CreateWorkflowDTOCredentialDiscriminatorProvider.Google,
                "google.calendar.oauth2-authorization" => CreateWorkflowDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization,
                "google.calendar.oauth2-client" => CreateWorkflowDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Client,
                "google.sheets.oauth2-authorization" => CreateWorkflowDTOCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization,
                "groq" => CreateWorkflowDTOCredentialDiscriminatorProvider.Groq,
                "hume" => CreateWorkflowDTOCredentialDiscriminatorProvider.Hume,
                "inflection-ai" => CreateWorkflowDTOCredentialDiscriminatorProvider.InflectionAi,
                "inworld" => CreateWorkflowDTOCredentialDiscriminatorProvider.Inworld,
                "langfuse" => CreateWorkflowDTOCredentialDiscriminatorProvider.Langfuse,
                "lmnt" => CreateWorkflowDTOCredentialDiscriminatorProvider.Lmnt,
                "make" => CreateWorkflowDTOCredentialDiscriminatorProvider.Make,
                "minimax" => CreateWorkflowDTOCredentialDiscriminatorProvider.Minimax,
                "mistral" => CreateWorkflowDTOCredentialDiscriminatorProvider.Mistral,
                "neuphonic" => CreateWorkflowDTOCredentialDiscriminatorProvider.Neuphonic,
                "openai" => CreateWorkflowDTOCredentialDiscriminatorProvider.Openai,
                "openrouter" => CreateWorkflowDTOCredentialDiscriminatorProvider.Openrouter,
                "perplexity-ai" => CreateWorkflowDTOCredentialDiscriminatorProvider.PerplexityAi,
                "playht" => CreateWorkflowDTOCredentialDiscriminatorProvider.Playht,
                "rime-ai" => CreateWorkflowDTOCredentialDiscriminatorProvider.RimeAi,
                "runpod" => CreateWorkflowDTOCredentialDiscriminatorProvider.Runpod,
                "s3" => CreateWorkflowDTOCredentialDiscriminatorProvider.S3,
                "slack-webhook" => CreateWorkflowDTOCredentialDiscriminatorProvider.SlackWebhook,
                "slack.oauth2-authorization" => CreateWorkflowDTOCredentialDiscriminatorProvider.SlackOauth2Authorization,
                "smallest-ai" => CreateWorkflowDTOCredentialDiscriminatorProvider.SmallestAi,
                "soniox" => CreateWorkflowDTOCredentialDiscriminatorProvider.Soniox,
                "speechmatics" => CreateWorkflowDTOCredentialDiscriminatorProvider.Speechmatics,
                "supabase" => CreateWorkflowDTOCredentialDiscriminatorProvider.Supabase,
                "tavus" => CreateWorkflowDTOCredentialDiscriminatorProvider.Tavus,
                "together-ai" => CreateWorkflowDTOCredentialDiscriminatorProvider.TogetherAi,
                "trieve" => CreateWorkflowDTOCredentialDiscriminatorProvider.Trieve,
                "twilio" => CreateWorkflowDTOCredentialDiscriminatorProvider.Twilio,
                "vonage" => CreateWorkflowDTOCredentialDiscriminatorProvider.Vonage,
                "webhook" => CreateWorkflowDTOCredentialDiscriminatorProvider.Webhook,
                "wellsaid" => CreateWorkflowDTOCredentialDiscriminatorProvider.Wellsaid,
                "xai" => CreateWorkflowDTOCredentialDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}