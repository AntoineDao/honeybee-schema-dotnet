
# HoneybeeSchema.Model.EnergyMaterialNoMass

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters. | 
**RValue** | **double** | The thermal resistance (R-value) of the material layer [m2-K/W]. | 
**Type** | **string** |  | [optional] [default to "EnergyMaterialNoMass"]
**Roughness** | **string** |  | [optional] [default to RoughnessEnum.MediumRough]
**ThermalAbsorptance** | **double** | Fraction of incident long wavelength radiation that is absorbed by the material. Default value is 0.9. | [optional] [default to 0.9M]
**SolarAbsorptance** | **double** | Fraction of incident solar radiation absorbed by the material. Default value is 0.7. | [optional] [default to 0.7M]
**VisibleAbsorptance** | **double** | Fraction of incident visible wavelength radiation absorbed by the material. Default value is 0.7. | [optional] [default to 0.7M]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

