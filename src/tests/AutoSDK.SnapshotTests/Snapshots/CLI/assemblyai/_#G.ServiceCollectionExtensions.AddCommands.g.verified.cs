//HintName: G.ServiceCollectionExtensions.AddCommands.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Provides extension methods for adding command services to the dependency injection container.
    /// </summary>
    internal static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers all command services required by the application into the dependency injection container.
        /// </summary>
        /// <param name="services">The <see cref="global::Microsoft.Extensions.DependencyInjection.IServiceCollection"/> to which the services will be added.</param>
        /// <returns>The updated <see cref="global::Microsoft.Extensions.DependencyInjection.IServiceCollection"/> instance.</returns>
        public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddCommands(
            this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services)
        {
            // Register individual command services as singletons
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                UploadFileCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                CreateTranscriptCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                ListTranscriptsCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                GetTranscriptCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                DeleteTranscriptCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                GetSubtitlesCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                GetTranscriptSentencesCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                GetTranscriptParagraphsCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                WordSearchCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                GetRedactedAudioCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                CreateTemporaryTokenCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                LemurTaskCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                LemurSummaryCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                LemurQuestionAnswerCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                LemurActionItemsCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                GetLemurResponseCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                PurgeLemurRequestDataCommand>(services);

            // Register grouped command services as singletons
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                TranscriptGroupCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                LeMURGroupCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                StreamingGroupCommand>(services);

            // Register the main command service as a singleton
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                MainCommand>(services);

            return services;
        }
    }
}