// COMPILER GENERATED CODE
// THIS WILL BE OVERWRITTEN AT EACH GENERATION
// EDIT AT YOUR OWN RISK

using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ECAClientFramework;
using ECAClientUtilities;
using ECACommonUtilities;
using ECACommonUtilities.Model;
using GSF.TimeSeries;

namespace LVC.Model
{
    [CompilerGenerated]
    public class Mapper : MapperBase
    {
        #region [ Constructors ]

        public Mapper(Framework framework)
            : base(framework, "Map_In")
        {
        }

        #endregion

        #region [ Methods ]

        public override void Map(IDictionary<MeasurementKey, IMeasurement> measurements)
        {
            SignalLookup.UpdateMeasurementLookup(measurements);
            TypeMapping inputMapping = MappingCompiler.GetTypeMapping(InputMapping);

            LVC.Model.test.Input inputData = CreatetestInput(inputMapping);
            KeyIndex = 0;
            LVC.Model.test._InputMeta inputMeta = Createtest_InputMeta(inputMapping);

            Algorithm.Output algorithmOutput = Algorithm.Execute(inputData, inputMeta);

            // TODO: Later versions will publish output to the openECA server
        }

        private LVC.Model.test.Input CreatetestInput(TypeMapping typeMapping)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);
            LVC.Model.test.Input obj = new LVC.Model.test.Input();

            {
                // Assign short value to "TapVTx4" field
                FieldMapping fieldMapping = fieldLookup["TapVTx4"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.TapVTx4 = (short)measurement.Value;
            }

            {
                // Assign double value to "MwVTx4" field
                FieldMapping fieldMapping = fieldLookup["MwVTx4"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MwVTx4 = (double)measurement.Value;
            }

            {
                // Assign double value to "MvrVTx4" field
                FieldMapping fieldMapping = fieldLookup["MvrVTx4"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MvrVTx4 = (double)measurement.Value;
            }

            {
                // Assign double value to "VoltsVTx4" field
                FieldMapping fieldMapping = fieldLookup["VoltsVTx4"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VoltsVTx4 = (double)measurement.Value;
            }

            {
                // Assign short value to "TapVTx5" field
                FieldMapping fieldMapping = fieldLookup["TapVTx5"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.TapVTx5 = (short)measurement.Value;
            }

            {
                // Assign double value to "MwVTx5" field
                FieldMapping fieldMapping = fieldLookup["MwVTx5"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MwVTx5 = (double)measurement.Value;
            }

            {
                // Assign double value to "MvrVTx5" field
                FieldMapping fieldMapping = fieldLookup["MvrVTx5"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MvrVTx5 = (double)measurement.Value;
            }

            {
                // Assign double value to "VoltsVTx5" field
                FieldMapping fieldMapping = fieldLookup["VoltsVTx5"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VoltsVTx5 = (double)measurement.Value;
            }

            {
                // Assign short value to "BusBkrVCap1" field
                FieldMapping fieldMapping = fieldLookup["BusBkrVCap1"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.BusBkrVCap1 = (short)measurement.Value;
            }

            {
                // Assign short value to "CapBkrVCap1" field
                FieldMapping fieldMapping = fieldLookup["CapBkrVCap1"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.CapBkrVCap1 = (short)measurement.Value;
            }

            {
                // Assign double value to "LocKvVCap1" field
                FieldMapping fieldMapping = fieldLookup["LocKvVCap1"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.LocKvVCap1 = (double)measurement.Value;
            }

            {
                // Assign short value to "BusBkrVCap2" field
                FieldMapping fieldMapping = fieldLookup["BusBkrVCap2"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.BusBkrVCap2 = (short)measurement.Value;
            }

            {
                // Assign short value to "CapBkrVCap2" field
                FieldMapping fieldMapping = fieldLookup["CapBkrVCap2"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.CapBkrVCap2 = (short)measurement.Value;
            }

            {
                // Assign double value to "LocKvVCap2" field
                FieldMapping fieldMapping = fieldLookup["LocKvVCap2"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.LocKvVCap2 = (double)measurement.Value;
            }

            {
                // Assign double value to "G1Mw" field
                FieldMapping fieldMapping = fieldLookup["G1Mw"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.G1Mw = (double)measurement.Value;
            }

            {
                // Assign double value to "G1Mvr" field
                FieldMapping fieldMapping = fieldLookup["G1Mvr"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.G1Mvr = (double)measurement.Value;
            }

            {
                // Assign double value to "G2Mw" field
                FieldMapping fieldMapping = fieldLookup["G2Mw"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.G2Mw = (double)measurement.Value;
            }

            {
                // Assign double value to "G2Mvr" field
                FieldMapping fieldMapping = fieldLookup["G2Mvr"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.G2Mvr = (double)measurement.Value;
            }

            return obj;
        }

        private LVC.Model.test._InputMeta Createtest_InputMeta(TypeMapping typeMapping)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);
            LVC.Model.test._InputMeta obj = new LVC.Model.test._InputMeta();

            {
                // Assign MetaValues value to "TapVTx4" field
                FieldMapping fieldMapping = fieldLookup["TapVTx4"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.TapVTx4 = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MwVTx4" field
                FieldMapping fieldMapping = fieldLookup["MwVTx4"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MwVTx4 = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MvrVTx4" field
                FieldMapping fieldMapping = fieldLookup["MvrVTx4"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MvrVTx4 = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "VoltsVTx4" field
                FieldMapping fieldMapping = fieldLookup["VoltsVTx4"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VoltsVTx4 = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "TapVTx5" field
                FieldMapping fieldMapping = fieldLookup["TapVTx5"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.TapVTx5 = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MwVTx5" field
                FieldMapping fieldMapping = fieldLookup["MwVTx5"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MwVTx5 = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MvrVTx5" field
                FieldMapping fieldMapping = fieldLookup["MvrVTx5"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MvrVTx5 = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "VoltsVTx5" field
                FieldMapping fieldMapping = fieldLookup["VoltsVTx5"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VoltsVTx5 = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "BusBkrVCap1" field
                FieldMapping fieldMapping = fieldLookup["BusBkrVCap1"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.BusBkrVCap1 = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "CapBkrVCap1" field
                FieldMapping fieldMapping = fieldLookup["CapBkrVCap1"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.CapBkrVCap1 = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "LocKvVCap1" field
                FieldMapping fieldMapping = fieldLookup["LocKvVCap1"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.LocKvVCap1 = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "BusBkrVCap2" field
                FieldMapping fieldMapping = fieldLookup["BusBkrVCap2"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.BusBkrVCap2 = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "CapBkrVCap2" field
                FieldMapping fieldMapping = fieldLookup["CapBkrVCap2"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.CapBkrVCap2 = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "LocKvVCap2" field
                FieldMapping fieldMapping = fieldLookup["LocKvVCap2"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.LocKvVCap2 = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "G1Mw" field
                FieldMapping fieldMapping = fieldLookup["G1Mw"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.G1Mw = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "G1Mvr" field
                FieldMapping fieldMapping = fieldLookup["G1Mvr"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.G1Mvr = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "G2Mw" field
                FieldMapping fieldMapping = fieldLookup["G2Mw"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.G2Mw = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "G2Mvr" field
                FieldMapping fieldMapping = fieldLookup["G2Mvr"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.G2Mvr = GetMetaValues(measurement);
            }

            return obj;
        }

        #endregion
    }
}
