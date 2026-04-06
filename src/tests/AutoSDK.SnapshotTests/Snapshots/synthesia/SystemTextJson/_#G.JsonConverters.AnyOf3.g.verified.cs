//HintName: G.JsonConverters.AnyOf3.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AnyOfJsonConverter<[global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties)] [global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties)] [global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties)] [global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties)] T1, [global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties)] [global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties)] [global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties)] [global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties)] T2, [global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties)] [global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties)] [global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties)] [global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties)] T3> : global::System.Text.Json.Serialization.JsonConverter<global::G.AnyOf<T1, T2, T3>>
    {
        /// <inheritdoc />
        public override global::G.AnyOf<T1, T2, T3> Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            var __score1 = 0;
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            T1? value1 = default;
            T2? value2 = default;
            T3? value3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        value1 = global::System.Text.Json.JsonSerializer.Deserialize<T1>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 1)
                {
                    try
                    {

                        value2 = global::System.Text.Json.JsonSerializer.Deserialize<T2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 2)
                {
                    try
                    {

                        value3 = global::System.Text.Json.JsonSerializer.Deserialize<T3>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value1 == null && value2 == null && value3 == null)
            {
                try
                {

                    value1 = global::System.Text.Json.JsonSerializer.Deserialize<T1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value2 = global::System.Text.Json.JsonSerializer.Deserialize<T2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    value3 = global::System.Text.Json.JsonSerializer.Deserialize<T3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.AnyOf<T1, T2, T3>(
                value1,

                value2,

                value3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AnyOf<T1, T2, T3> value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsValue1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeof(T1), options);
            }
            else if (value.IsValue2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeof(T2), options);
            }
            else if (value.IsValue3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeof(T3), options);
            }
        }
    }
}