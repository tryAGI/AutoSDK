using System.Text.Json;
using System.Text.Json.Serialization;
using AutoSDK.JsonConverters;
using JsonSerializer = System.Text.Json.JsonSerializer;
using AutoSDK.UnitTests.OneOfDiscriminator;

namespace AutoSDK.UnitTests;

public partial class JsonTests
{
    private readonly JsonSerializerOptions _animalSystemTextJsonOptions = new()
    {
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        Converters =
        {
            new AnimalConverterSystemTextJson(),
        }
    };

    [TestMethod]
    public void AnyOf_SystemTextJson_Discriminator_Animal_Valid1()
    {
        var response = JsonSerializer.Deserialize<AnyOf<Cat, Dog>>(/*language=json*/
            """
            {
              "pet_type": "Cat",
              "age": 3
            }
            """, _animalSystemTextJsonOptions);
        response.Should().NotBeNull();
        response!.Value1.Should().NotBeNull();
        response!.Value2.Should().BeNull();
        response.Value1!.pet_type.Should().Be("Cat");
        response.Value1!.age.Should().Be(3);
    }

    [TestMethod]
    public void AnyOf_SystemTextJson_Discriminator_Animal_Valid2()
    {
        var response = JsonSerializer.Deserialize<AnyOf<Cat, Dog>>(/*language=json*/
            """
            {
              "pet_type": "Dog",
              "bark": true
            }
            """, _animalSystemTextJsonOptions);
        response.Should().NotBeNull();
        response!.Value1.Should().BeNull();
        response!.Value2.Should().NotBeNull();
        response.Value2!.pet_type.Should().Be("Dog");
        response.Value2!.bark.Should().Be(true);
    }

    [TestMethod]
    public void AnyOf_SystemTextJson_Discriminator_Animal_Valid3()
    {
        var response = JsonSerializer.Deserialize<AnyOf<Cat, Dog>>(/*language=json*/
            """
            {
              "pet_type": "Dog",
              "bark": false,
              "breed": "Dingo"
            }
            """, _animalSystemTextJsonOptions);
        response.Should().NotBeNull();
        response!.Value1.Should().BeNull();
        response!.Value2.Should().NotBeNull();
        response.Value2!.pet_type.Should().Be("Dog");
        response.Value2!.bark.Should().Be(false);
        response.Value2!.breed.Should().Be("Dingo");
    }

    [TestMethod]
    public void AnyOf_SystemTextJson_Discriminator_Animal_NotValid1()
    {
        // Does not include the pet_type property
        var deserialization = () => JsonSerializer.Deserialize<AnyOf<Cat, Dog>>(/*language=json*/
            """
            {
              "age": 3
            }
            """, _animalSystemTextJsonOptions);
        deserialization.Should().Throw<JsonException>();
    }

    [TestMethod]
    public void AnyOf_SystemTextJson_Discriminator_Animal_NotValid2()
    {
        // The `Cat` schema does not have the `bark` property
        var deserialization = () => JsonSerializer.Deserialize<AnyOf<Cat, Dog>>(/*language=json*/
            """
            {
              "pet_type": "Cat",
              "bark": true
            }
            """, _animalSystemTextJsonOptions);
        deserialization.Should().NotThrow<JsonException>();
        
        // While this is in conflict with OpenAPI standards, this requirement would break backwards compatibility when adding new properties.
    }
}

public class AnimalConverterSystemTextJson : global::System.Text.Json.Serialization.JsonConverter<AnyOf<Cat, Dog>>
{
    public override AnyOf<Cat, Dog> Read(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options)
    {
        options = options ?? throw new global::System.ArgumentNullException(nameof(options));
        //options.TypeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

        Pet? discriminator = default;
        try
        {
            var readerCopy = reader;
            if (options.TypeInfoResolver != null)
            {
                var typeInfo = options.TypeInfoResolver.GetTypeInfo(typeof(Pet), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<Pet> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(Pet).Name}");
                discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            else
            {
                discriminator = global::System.Text.Json.JsonSerializer.Deserialize<Pet>(ref readerCopy, options);
            }
        }
        catch (global::System.Text.Json.JsonException)
        {
        }
        
        Cat? value1 = default;
        if (discriminator?.pet_type == "Cat")
        {
            if (options.TypeInfoResolver != null)
            {
                var typeInfo = options.TypeInfoResolver.GetTypeInfo(typeof(Cat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<Cat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(Cat).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else
            {
                value1 = global::System.Text.Json.JsonSerializer.Deserialize<Cat>(ref reader, options);
            }
        }
    
        Dog? value2 = default;
        if (discriminator?.pet_type == "Dog")
        {
            if (options.TypeInfoResolver != null)
            {
                var typeInfo = options.TypeInfoResolver.GetTypeInfo(typeof(Dog), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<Dog> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(Dog).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else
            {
                value2 = global::System.Text.Json.JsonSerializer.Deserialize<Dog>(ref reader, options);
            }
        }
    
        var result = new AnyOf<Cat, Dog>(value1, value2);
        if (!result.Validate())
        {
            throw new global::System.Text.Json.JsonException($"Invalid JSON format for AnyOf<{typeof(Cat).Name}, {typeof(Dog).Name}>");
        }
    
        return result;
    }

    public override void Write(
        global::System.Text.Json.Utf8JsonWriter writer,
        AnyOf<Cat, Dog> value,
        global::System.Text.Json.JsonSerializerOptions options)
    {
        options = options ?? throw new global::System.ArgumentNullException(nameof(options));

        if (!value.Validate())
        {
            throw new global::System.Text.Json.JsonException($"Invalid AnyOf<{typeof(Cat).Name}, {typeof(Dog).Name}> object.");
        }

        if (value.IsValue1)
        {
            if (options.TypeInfoResolver != null)
            {
                var typeInfo = options.TypeInfoResolver.GetTypeInfo(typeof(Cat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<Cat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(Cat).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeof(Cat), options);
            }
        }
        else if (value.IsValue2)
        {
            if (options.TypeInfoResolver != null)
            {                
                var typeInfo = options.TypeInfoResolver.GetTypeInfo(typeof(Dog), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<Dog?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(Dog).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeof(Dog), options);
            }
        }
    }
}