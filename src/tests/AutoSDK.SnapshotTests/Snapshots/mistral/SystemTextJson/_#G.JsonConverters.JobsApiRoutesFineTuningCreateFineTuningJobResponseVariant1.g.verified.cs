﻿//HintName: G.JsonConverters.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1>
    {
        /// <inheritdoc />
        public override global::G.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CompletionJobOut? completion = default;
            if (discriminator?.JobType == global::G.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType.Completion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompletionJobOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompletionJobOut> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CompletionJobOut)}");
                completion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ClassifierJobOut? classifier = default;
            if (discriminator?.JobType == global::G.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType.Classifier)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClassifierJobOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClassifierJobOut> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ClassifierJobOut)}");
                classifier = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1(
                discriminator?.JobType,
                completion,
                classifier
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCompletion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompletionJobOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompletionJobOut?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CompletionJobOut).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completion, typeInfo);
            }
            else if (value.IsClassifier)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClassifierJobOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClassifierJobOut?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ClassifierJobOut).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Classifier, typeInfo);
            }
        }
    }
}