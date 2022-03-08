#define ICALL_TABLE_corlib 1

static int corlib_icall_indexes [] = {
202,
209,
210,
211,
212,
213,
214,
215,
216,
217,
220,
221,
406,
407,
409,
438,
439,
440,
460,
461,
462,
463,
464,
555,
556,
557,
560,
617,
618,
619,
622,
624,
626,
628,
633,
641,
642,
643,
644,
645,
646,
647,
648,
649,
650,
651,
652,
653,
654,
655,
656,
657,
658,
659,
661,
662,
663,
664,
665,
666,
667,
668,
764,
765,
766,
767,
768,
769,
770,
771,
772,
773,
774,
775,
776,
777,
778,
779,
780,
781,
782,
783,
784,
785,
786,
787,
788,
924,
925,
933,
936,
938,
944,
945,
947,
948,
952,
954,
956,
957,
958,
959,
961,
962,
963,
966,
967,
970,
971,
972,
1049,
1050,
1052,
1060,
1061,
1062,
1063,
1064,
1068,
1069,
1070,
1071,
1072,
1073,
1075,
1076,
1077,
1079,
1080,
1082,
1086,
1087,
1088,
1361,
1583,
1584,
8787,
8788,
8790,
8791,
8792,
8793,
8794,
8795,
8797,
8799,
8801,
8802,
8803,
8811,
8813,
8818,
8819,
8821,
8823,
8825,
8850,
8859,
8860,
8862,
8863,
8864,
8865,
8866,
8868,
8870,
10118,
10122,
10124,
10125,
10126,
10127,
10201,
10202,
10203,
10204,
10225,
10226,
10227,
10228,
10230,
10276,
10330,
10333,
10343,
10344,
10345,
10346,
10770,
10771,
10776,
10777,
10829,
10830,
10831,
10860,
10866,
10873,
10883,
10887,
10979,
10989,
10990,
11003,
11004,
11005,
11006,
11007,
11008,
11009,
11016,
11032,
11053,
11054,
11063,
11065,
11072,
11073,
11076,
11078,
11083,
11089,
11090,
11097,
11099,
11109,
11112,
11113,
11114,
11125,
11137,
11143,
11144,
11145,
11147,
11148,
11158,
11177,
11199,
11200,
11201,
11202,
11203,
11220,
11225,
11230,
11261,
11262,
11798,
11799,
11883,
11974,
12294,
12295,
12307,
12308,
12309,
12315,
12400,
12582,
12583,
13576,
13577,
13578,
14929,
14948,
14955,
14956,
14958,
};
void ves_icall_System_Array_InternalCreate (int,int,int,int,int);
int ves_icall_System_Array_GetCorElementTypeOfElementType_raw (int,int);
int ves_icall_System_Array_IsValueOfElementType_raw (int,int,int);
int ves_icall_System_Array_CanChangePrimitive (int,int,int);
int ves_icall_System_Array_FastCopy_raw (int,int,int,int,int,int);
int ves_icall_System_Array_GetLength_raw (int,int,int);
int ves_icall_System_Array_GetLowerBound_raw (int,int,int);
void ves_icall_System_Array_GetGenericValue_icall (int,int,int);
int ves_icall_System_Array_GetValueImpl_raw (int,int,int);
void ves_icall_System_Array_SetGenericValue_icall (int,int,int);
void ves_icall_System_Array_SetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_SetValueRelaxedImpl_raw (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_Memmove (int,int,int);
void ves_icall_System_Buffer_BulkMoveWithWriteBarrier (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_ZeroMemory (int,int);
int ves_icall_System_Delegate_AllocDelegateLike_internal_raw (int,int);
int ves_icall_System_Delegate_CreateDelegate_internal_raw (int,int,int,int,int);
int ves_icall_System_Delegate_GetVirtualMethod_internal_raw (int,int);
int ves_icall_System_Enum_GetEnumValuesAndNames_raw (int,int,int,int);
int ves_icall_System_Enum_ToObject_raw (int,int64_t,int);
int ves_icall_System_Enum_InternalGetCorElementType_raw (int,int);
int ves_icall_System_Enum_get_underlying_type_raw (int,int);
int ves_icall_System_Enum_InternalHasFlag_raw (int,int,int);
int ves_icall_System_Environment_get_ProcessorCount ();
int ves_icall_System_Environment_get_TickCount ();
int64_t ves_icall_System_Environment_get_TickCount64 ();
void ves_icall_System_Environment_FailFast_raw (int,int,int,int);
int ves_icall_System_GC_GetCollectionCount (int);
void ves_icall_System_GC_register_ephemeron_array_raw (int,int);
int ves_icall_System_GC_get_ephemeron_tombstone_raw (int);
void ves_icall_System_GC_SuppressFinalize_raw (int,int);
void ves_icall_System_GC_ReRegisterForFinalize_raw (int,int);
void ves_icall_System_GC_GetGCMemoryInfo (int,int,int,int,int,int);
int ves_icall_System_GC_AllocPinnedArray_raw (int,int,int);
int ves_icall_System_Object_MemberwiseClone_raw (int,int);
double ves_icall_System_Math_Abs_double (double);
float ves_icall_System_Math_Abs_single (float);
double ves_icall_System_Math_Acos (double);
double ves_icall_System_Math_Acosh (double);
double ves_icall_System_Math_Asin (double);
double ves_icall_System_Math_Asinh (double);
double ves_icall_System_Math_Atan (double);
double ves_icall_System_Math_Atan2 (double,double);
double ves_icall_System_Math_Atanh (double);
double ves_icall_System_Math_Cbrt (double);
double ves_icall_System_Math_Ceiling (double);
double ves_icall_System_Math_Cos (double);
double ves_icall_System_Math_Cosh (double);
double ves_icall_System_Math_Exp (double);
double ves_icall_System_Math_Floor (double);
double ves_icall_System_Math_Log (double);
double ves_icall_System_Math_Log10 (double);
double ves_icall_System_Math_Pow (double,double);
double ves_icall_System_Math_Sin (double);
double ves_icall_System_Math_Sinh (double);
double ves_icall_System_Math_Sqrt (double);
double ves_icall_System_Math_Tan (double);
double ves_icall_System_Math_Tanh (double);
double ves_icall_System_Math_FusedMultiplyAdd (double,double,double);
int ves_icall_System_Math_ILogB (double);
double ves_icall_System_Math_Log2 (double);
double ves_icall_System_Math_ModF (double,int);
float ves_icall_System_MathF_Acos (float);
float ves_icall_System_MathF_Acosh (float);
float ves_icall_System_MathF_Asin (float);
float ves_icall_System_MathF_Asinh (float);
float ves_icall_System_MathF_Atan (float);
float ves_icall_System_MathF_Atan2 (float,float);
float ves_icall_System_MathF_Atanh (float);
float ves_icall_System_MathF_Cbrt (float);
float ves_icall_System_MathF_Ceiling (float);
float ves_icall_System_MathF_Cos (float);
float ves_icall_System_MathF_Cosh (float);
float ves_icall_System_MathF_Exp (float);
float ves_icall_System_MathF_Floor (float);
float ves_icall_System_MathF_Log (float);
float ves_icall_System_MathF_Log10 (float);
float ves_icall_System_MathF_Pow (float,float);
float ves_icall_System_MathF_Sin (float);
float ves_icall_System_MathF_Sinh (float);
float ves_icall_System_MathF_Sqrt (float);
float ves_icall_System_MathF_Tan (float);
float ves_icall_System_MathF_Tanh (float);
float ves_icall_System_MathF_FusedMultiplyAdd (float,float,float);
int ves_icall_System_MathF_ILogB (float);
float ves_icall_System_MathF_Log2 (float);
float ves_icall_System_MathF_ModF (float,int);
int ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw (int,int,int);
int ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw (int,int,int);
int ves_icall_RuntimeType_make_array_type_raw (int,int,int);
int ves_icall_RuntimeType_make_byref_type_raw (int,int);
int ves_icall_RuntimeType_MakePointerType_raw (int,int);
int ves_icall_RuntimeType_MakeGenericType_raw (int,int,int);
int ves_icall_RuntimeType_GetMethodsByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetPropertiesByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetConstructors_native_raw (int,int,int);
void ves_icall_RuntimeType_GetInterfaceMapData_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetPacking_raw (int,int,int,int);
int ves_icall_System_Activator_CreateInstanceInternal_raw (int,int);
int ves_icall_RuntimeType_get_DeclaringMethod_raw (int,int);
int ves_icall_System_RuntimeType_getFullName_raw (int,int,int,int);
int ves_icall_RuntimeType_GetGenericArguments_raw (int,int,int);
int ves_icall_RuntimeType_GetGenericParameterPosition_raw (int,int);
int ves_icall_RuntimeType_GetEvents_native_raw (int,int,int,int);
int ves_icall_RuntimeType_GetFields_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetInterfaces_raw (int,int);
int ves_icall_RuntimeType_GetNestedTypes_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_get_DeclaringType_raw (int,int);
int ves_icall_RuntimeType_get_Name_raw (int,int);
int ves_icall_RuntimeType_get_Namespace_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetAttributes_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetCorElementType_raw (int,int);
int ves_icall_RuntimeTypeHandle_HasInstantiation_raw (int,int);
int ves_icall_RuntimeTypeHandle_IsComObject_raw (int,int);
int ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_HasReferences_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetArrayRank_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetAssembly_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetElementType_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetModule_raw (int,int);
int ves_icall_RuntimeTypeHandle_IsGenericVariable_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetBaseType_raw (int,int);
int ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw (int,int);
int ves_icall_RuntimeTypeHandle_is_subclass_of (int,int);
int ves_icall_RuntimeTypeHandle_IsByRefLike_raw (int,int);
int ves_icall_System_RuntimeTypeHandle_internal_from_name_raw (int,int,int,int,int,int);
int ves_icall_System_String_FastAllocateString_raw (int,int);
int ves_icall_System_String_InternalIsInterned_raw (int,int);
int ves_icall_System_String_InternalIntern_raw (int,int);
int ves_icall_System_Type_internal_from_handle_raw (int,int);
int ves_icall_System_ValueType_InternalGetHashCode_raw (int,int,int);
int ves_icall_System_ValueType_Equals_raw (int,int,int,int);
int ves_icall_System_Threading_Interlocked_CompareExchange_Int (int,int,int);
void ves_icall_System_Threading_Interlocked_CompareExchange_Object (int,int,int,int);
int ves_icall_System_Threading_Interlocked_Decrement_Int (int);
int64_t ves_icall_System_Threading_Interlocked_Decrement_Long (int);
int ves_icall_System_Threading_Interlocked_Increment_Int (int);
int64_t ves_icall_System_Threading_Interlocked_Increment_Long (int);
int ves_icall_System_Threading_Interlocked_Exchange_Int (int,int);
void ves_icall_System_Threading_Interlocked_Exchange_Object (int,int,int);
int64_t ves_icall_System_Threading_Interlocked_CompareExchange_Long (int,int64_t,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Exchange_Long (int,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Read_Long (int);
int ves_icall_System_Threading_Interlocked_Add_Int (int,int);
int64_t ves_icall_System_Threading_Interlocked_Add_Long (int,int64_t);
void ves_icall_System_Threading_Monitor_Monitor_Enter_raw (int,int);
void mono_monitor_exit_icall_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_test_synchronised_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_wait_raw (int,int,int,int);
void ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw (int,int,int,int,int);
int ves_icall_System_Threading_Thread_GetCurrentProcessorNumber_raw (int);
void ves_icall_System_Threading_Thread_InitInternal_raw (int,int);
int ves_icall_System_Threading_Thread_GetCurrentThread ();
void ves_icall_System_Threading_InternalThread_Thread_free_internal_raw (int,int);
int ves_icall_System_Threading_Thread_GetState_raw (int,int);
void ves_icall_System_Threading_Thread_SetState_raw (int,int,int);
void ves_icall_System_Threading_Thread_ClrState_raw (int,int,int);
void ves_icall_System_Threading_Thread_SetName_icall_raw (int,int,int,int);
int ves_icall_System_Threading_Thread_YieldInternal ();
void ves_icall_System_Threading_Thread_SetPriority_raw (int,int,int);
void ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw (int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw (int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw (int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw (int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw (int,int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw (int);
int ves_icall_System_GCHandle_InternalAlloc_raw (int,int,int);
void ves_icall_System_GCHandle_InternalFree_raw (int,int);
int ves_icall_System_GCHandle_InternalGet_raw (int,int);
void ves_icall_System_GCHandle_InternalSet_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError ();
void ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError (int);
void ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw (int,int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_IsPinnableType_raw (int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw (int,int,int,int,int,int);
int mono_object_hash_icall_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw (int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw (int,int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunClassConstructor_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack ();
int ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw (int,int);
int ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw (int);
int ves_icall_System_Reflection_Assembly_InternalLoad_raw (int,int,int,int);
int ves_icall_System_Reflection_Assembly_InternalGetType_raw (int,int,int,int,int,int);
void mono_digest_get_public_token (int,int,int);
int ves_icall_System_Reflection_AssemblyName_GetNativeName (int);
int ves_icall_System_Reflection_AssemblyName_ParseAssemblyName (int,int,int,int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw (int,int,int,int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw (int,int);
int ves_icall_MonoCustomAttrs_IsDefinedInternal_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_get_EntryPoint_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_get_location_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_get_code_base_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_get_fullname_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_InternalImageRuntimeVersion_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw (int,int,int,int,int);
int ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw (int,int);
void ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw (int,int,int,int,int,int,int);
void ves_icall_RuntimeEventInfo_get_event_info_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_ResolveType_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetParentType_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_GetFieldOffset_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetValueInternal_raw (int,int,int);
void ves_icall_RuntimeFieldInfo_SetValueInternal_raw (int,int,int,int);
int ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
void ves_icall_get_method_info_raw (int,int,int);
int ves_icall_get_method_attributes (int);
int ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw (int,int,int);
int ves_icall_System_MonoMethodInfo_get_retval_marshal_raw (int,int);
int ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw (int,int,int,int);
int ves_icall_RuntimeMethodInfo_get_name_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_base_method_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
void ves_icall_RuntimeMethodInfo_GetPInvoke_raw (int,int,int,int,int);
int ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw (int,int,int);
int ves_icall_RuntimeMethodInfo_GetGenericArguments_raw (int,int);
int ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimeModule_GetMDStreamVersion_raw (int,int);
int ves_icall_System_Reflection_RuntimeModule_InternalGetTypes_raw (int,int);
void ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw (int,int,int);
int ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw (int,int,int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_RuntimeParameterInfo_GetTypeModifiers_raw (int,int,int,int,int);
void ves_icall_RuntimePropertyInfo_get_property_info_raw (int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw (int,int,int);
void ves_icall_AssemblyBuilder_basic_init_raw (int,int);
void ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw (int,int);
int ves_icall_CustomAttributeBuilder_GetBlob_raw (int,int,int,int,int,int,int,int);
void ves_icall_DynamicMethod_create_dynamic_method_raw (int,int);
void ves_icall_ModuleBuilder_basic_init_raw (int,int);
void ves_icall_ModuleBuilder_set_wrappers_type_raw (int,int,int);
int ves_icall_ModuleBuilder_getUSIndex_raw (int,int,int);
int ves_icall_ModuleBuilder_getToken_raw (int,int,int,int);
int ves_icall_ModuleBuilder_getMethodToken_raw (int,int,int,int);
void ves_icall_ModuleBuilder_RegisterToken_raw (int,int,int,int);
int ves_icall_TypeBuilder_create_runtime_class_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw (int,int);
int ves_icall_System_Diagnostics_Debugger_IsAttached_internal ();
int ves_icall_System_Diagnostics_Debugger_IsLogging ();
void ves_icall_System_Diagnostics_Debugger_Log (int,int,int);
int ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass (int);
void ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree (int);
void ves_icall_Mono_RuntimeMarshal_FreeAssemblyName (int,int);
int ves_icall_Mono_SafeStringMarshal_StringToUtf8 (int);
void ves_icall_Mono_SafeStringMarshal_GFree (int);
static void *corlib_icall_funcs [] = {
// token 202,
ves_icall_System_Array_InternalCreate,
// token 209,
ves_icall_System_Array_GetCorElementTypeOfElementType_raw,
// token 210,
ves_icall_System_Array_IsValueOfElementType_raw,
// token 211,
ves_icall_System_Array_CanChangePrimitive,
// token 212,
ves_icall_System_Array_FastCopy_raw,
// token 213,
ves_icall_System_Array_GetLength_raw,
// token 214,
ves_icall_System_Array_GetLowerBound_raw,
// token 215,
ves_icall_System_Array_GetGenericValue_icall,
// token 216,
ves_icall_System_Array_GetValueImpl_raw,
// token 217,
ves_icall_System_Array_SetGenericValue_icall,
// token 220,
ves_icall_System_Array_SetValueImpl_raw,
// token 221,
ves_icall_System_Array_SetValueRelaxedImpl_raw,
// token 406,
ves_icall_System_Runtime_RuntimeImports_Memmove,
// token 407,
ves_icall_System_Buffer_BulkMoveWithWriteBarrier,
// token 409,
ves_icall_System_Runtime_RuntimeImports_ZeroMemory,
// token 438,
ves_icall_System_Delegate_AllocDelegateLike_internal_raw,
// token 439,
ves_icall_System_Delegate_CreateDelegate_internal_raw,
// token 440,
ves_icall_System_Delegate_GetVirtualMethod_internal_raw,
// token 460,
ves_icall_System_Enum_GetEnumValuesAndNames_raw,
// token 461,
ves_icall_System_Enum_ToObject_raw,
// token 462,
ves_icall_System_Enum_InternalGetCorElementType_raw,
// token 463,
ves_icall_System_Enum_get_underlying_type_raw,
// token 464,
ves_icall_System_Enum_InternalHasFlag_raw,
// token 555,
ves_icall_System_Environment_get_ProcessorCount,
// token 556,
ves_icall_System_Environment_get_TickCount,
// token 557,
ves_icall_System_Environment_get_TickCount64,
// token 560,
ves_icall_System_Environment_FailFast_raw,
// token 617,
ves_icall_System_GC_GetCollectionCount,
// token 618,
ves_icall_System_GC_register_ephemeron_array_raw,
// token 619,
ves_icall_System_GC_get_ephemeron_tombstone_raw,
// token 622,
ves_icall_System_GC_SuppressFinalize_raw,
// token 624,
ves_icall_System_GC_ReRegisterForFinalize_raw,
// token 626,
ves_icall_System_GC_GetGCMemoryInfo,
// token 628,
ves_icall_System_GC_AllocPinnedArray_raw,
// token 633,
ves_icall_System_Object_MemberwiseClone_raw,
// token 641,
ves_icall_System_Math_Abs_double,
// token 642,
ves_icall_System_Math_Abs_single,
// token 643,
ves_icall_System_Math_Acos,
// token 644,
ves_icall_System_Math_Acosh,
// token 645,
ves_icall_System_Math_Asin,
// token 646,
ves_icall_System_Math_Asinh,
// token 647,
ves_icall_System_Math_Atan,
// token 648,
ves_icall_System_Math_Atan2,
// token 649,
ves_icall_System_Math_Atanh,
// token 650,
ves_icall_System_Math_Cbrt,
// token 651,
ves_icall_System_Math_Ceiling,
// token 652,
ves_icall_System_Math_Cos,
// token 653,
ves_icall_System_Math_Cosh,
// token 654,
ves_icall_System_Math_Exp,
// token 655,
ves_icall_System_Math_Floor,
// token 656,
ves_icall_System_Math_Log,
// token 657,
ves_icall_System_Math_Log10,
// token 658,
ves_icall_System_Math_Pow,
// token 659,
ves_icall_System_Math_Sin,
// token 661,
ves_icall_System_Math_Sinh,
// token 662,
ves_icall_System_Math_Sqrt,
// token 663,
ves_icall_System_Math_Tan,
// token 664,
ves_icall_System_Math_Tanh,
// token 665,
ves_icall_System_Math_FusedMultiplyAdd,
// token 666,
ves_icall_System_Math_ILogB,
// token 667,
ves_icall_System_Math_Log2,
// token 668,
ves_icall_System_Math_ModF,
// token 764,
ves_icall_System_MathF_Acos,
// token 765,
ves_icall_System_MathF_Acosh,
// token 766,
ves_icall_System_MathF_Asin,
// token 767,
ves_icall_System_MathF_Asinh,
// token 768,
ves_icall_System_MathF_Atan,
// token 769,
ves_icall_System_MathF_Atan2,
// token 770,
ves_icall_System_MathF_Atanh,
// token 771,
ves_icall_System_MathF_Cbrt,
// token 772,
ves_icall_System_MathF_Ceiling,
// token 773,
ves_icall_System_MathF_Cos,
// token 774,
ves_icall_System_MathF_Cosh,
// token 775,
ves_icall_System_MathF_Exp,
// token 776,
ves_icall_System_MathF_Floor,
// token 777,
ves_icall_System_MathF_Log,
// token 778,
ves_icall_System_MathF_Log10,
// token 779,
ves_icall_System_MathF_Pow,
// token 780,
ves_icall_System_MathF_Sin,
// token 781,
ves_icall_System_MathF_Sinh,
// token 782,
ves_icall_System_MathF_Sqrt,
// token 783,
ves_icall_System_MathF_Tan,
// token 784,
ves_icall_System_MathF_Tanh,
// token 785,
ves_icall_System_MathF_FusedMultiplyAdd,
// token 786,
ves_icall_System_MathF_ILogB,
// token 787,
ves_icall_System_MathF_Log2,
// token 788,
ves_icall_System_MathF_ModF,
// token 924,
ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw,
// token 925,
ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw,
// token 933,
ves_icall_RuntimeType_make_array_type_raw,
// token 936,
ves_icall_RuntimeType_make_byref_type_raw,
// token 938,
ves_icall_RuntimeType_MakePointerType_raw,
// token 944,
ves_icall_RuntimeType_MakeGenericType_raw,
// token 945,
ves_icall_RuntimeType_GetMethodsByName_native_raw,
// token 947,
ves_icall_RuntimeType_GetPropertiesByName_native_raw,
// token 948,
ves_icall_RuntimeType_GetConstructors_native_raw,
// token 952,
ves_icall_RuntimeType_GetInterfaceMapData_raw,
// token 954,
ves_icall_RuntimeType_GetPacking_raw,
// token 956,
ves_icall_System_Activator_CreateInstanceInternal_raw,
// token 957,
ves_icall_RuntimeType_get_DeclaringMethod_raw,
// token 958,
ves_icall_System_RuntimeType_getFullName_raw,
// token 959,
ves_icall_RuntimeType_GetGenericArguments_raw,
// token 961,
ves_icall_RuntimeType_GetGenericParameterPosition_raw,
// token 962,
ves_icall_RuntimeType_GetEvents_native_raw,
// token 963,
ves_icall_RuntimeType_GetFields_native_raw,
// token 966,
ves_icall_RuntimeType_GetInterfaces_raw,
// token 967,
ves_icall_RuntimeType_GetNestedTypes_native_raw,
// token 970,
ves_icall_RuntimeType_get_DeclaringType_raw,
// token 971,
ves_icall_RuntimeType_get_Name_raw,
// token 972,
ves_icall_RuntimeType_get_Namespace_raw,
// token 1049,
ves_icall_RuntimeTypeHandle_GetAttributes_raw,
// token 1050,
ves_icall_reflection_get_token_raw,
// token 1052,
ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw,
// token 1060,
ves_icall_RuntimeTypeHandle_GetCorElementType_raw,
// token 1061,
ves_icall_RuntimeTypeHandle_HasInstantiation_raw,
// token 1062,
ves_icall_RuntimeTypeHandle_IsComObject_raw,
// token 1063,
ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw,
// token 1064,
ves_icall_RuntimeTypeHandle_HasReferences_raw,
// token 1068,
ves_icall_RuntimeTypeHandle_GetArrayRank_raw,
// token 1069,
ves_icall_RuntimeTypeHandle_GetAssembly_raw,
// token 1070,
ves_icall_RuntimeTypeHandle_GetElementType_raw,
// token 1071,
ves_icall_RuntimeTypeHandle_GetModule_raw,
// token 1072,
ves_icall_RuntimeTypeHandle_IsGenericVariable_raw,
// token 1073,
ves_icall_RuntimeTypeHandle_GetBaseType_raw,
// token 1075,
ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw,
// token 1076,
ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition_raw,
// token 1077,
ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw,
// token 1079,
ves_icall_RuntimeTypeHandle_is_subclass_of,
// token 1080,
ves_icall_RuntimeTypeHandle_IsByRefLike_raw,
// token 1082,
ves_icall_System_RuntimeTypeHandle_internal_from_name_raw,
// token 1086,
ves_icall_System_String_FastAllocateString_raw,
// token 1087,
ves_icall_System_String_InternalIsInterned_raw,
// token 1088,
ves_icall_System_String_InternalIntern_raw,
// token 1361,
ves_icall_System_Type_internal_from_handle_raw,
// token 1583,
ves_icall_System_ValueType_InternalGetHashCode_raw,
// token 1584,
ves_icall_System_ValueType_Equals_raw,
// token 8787,
ves_icall_System_Threading_Interlocked_CompareExchange_Int,
// token 8788,
ves_icall_System_Threading_Interlocked_CompareExchange_Object,
// token 8790,
ves_icall_System_Threading_Interlocked_Decrement_Int,
// token 8791,
ves_icall_System_Threading_Interlocked_Decrement_Long,
// token 8792,
ves_icall_System_Threading_Interlocked_Increment_Int,
// token 8793,
ves_icall_System_Threading_Interlocked_Increment_Long,
// token 8794,
ves_icall_System_Threading_Interlocked_Exchange_Int,
// token 8795,
ves_icall_System_Threading_Interlocked_Exchange_Object,
// token 8797,
ves_icall_System_Threading_Interlocked_CompareExchange_Long,
// token 8799,
ves_icall_System_Threading_Interlocked_Exchange_Long,
// token 8801,
ves_icall_System_Threading_Interlocked_Read_Long,
// token 8802,
ves_icall_System_Threading_Interlocked_Add_Int,
// token 8803,
ves_icall_System_Threading_Interlocked_Add_Long,
// token 8811,
ves_icall_System_Threading_Monitor_Monitor_Enter_raw,
// token 8813,
mono_monitor_exit_icall_raw,
// token 8818,
ves_icall_System_Threading_Monitor_Monitor_test_synchronised_raw,
// token 8819,
ves_icall_System_Threading_Monitor_Monitor_pulse_raw,
// token 8821,
ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw,
// token 8823,
ves_icall_System_Threading_Monitor_Monitor_wait_raw,
// token 8825,
ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw,
// token 8850,
ves_icall_System_Threading_Thread_GetCurrentProcessorNumber_raw,
// token 8859,
ves_icall_System_Threading_Thread_InitInternal_raw,
// token 8860,
ves_icall_System_Threading_Thread_GetCurrentThread,
// token 8862,
ves_icall_System_Threading_InternalThread_Thread_free_internal_raw,
// token 8863,
ves_icall_System_Threading_Thread_GetState_raw,
// token 8864,
ves_icall_System_Threading_Thread_SetState_raw,
// token 8865,
ves_icall_System_Threading_Thread_ClrState_raw,
// token 8866,
ves_icall_System_Threading_Thread_SetName_icall_raw,
// token 8868,
ves_icall_System_Threading_Thread_YieldInternal,
// token 8870,
ves_icall_System_Threading_Thread_SetPriority_raw,
// token 10118,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw,
// token 10122,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw,
// token 10124,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw,
// token 10125,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw,
// token 10126,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw,
// token 10127,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw,
// token 10201,
ves_icall_System_GCHandle_InternalAlloc_raw,
// token 10202,
ves_icall_System_GCHandle_InternalFree_raw,
// token 10203,
ves_icall_System_GCHandle_InternalGet_raw,
// token 10204,
ves_icall_System_GCHandle_InternalSet_raw,
// token 10225,
ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError,
// token 10226,
ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError,
// token 10227,
ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw,
// token 10228,
ves_icall_System_Runtime_InteropServices_Marshal_IsPinnableType_raw,
// token 10230,
ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw,
// token 10276,
ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw,
// token 10330,
mono_object_hash_icall_raw,
// token 10333,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw,
// token 10343,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw,
// token 10344,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw,
// token 10345,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunClassConstructor_raw,
// token 10346,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack,
// token 10770,
ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw,
// token 10771,
ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw,
// token 10776,
ves_icall_System_Reflection_Assembly_InternalLoad_raw,
// token 10777,
ves_icall_System_Reflection_Assembly_InternalGetType_raw,
// token 10829,
mono_digest_get_public_token,
// token 10830,
ves_icall_System_Reflection_AssemblyName_GetNativeName,
// token 10831,
ves_icall_System_Reflection_AssemblyName_ParseAssemblyName,
// token 10860,
ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw,
// token 10866,
ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw,
// token 10873,
ves_icall_MonoCustomAttrs_IsDefinedInternal_raw,
// token 10883,
ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw,
// token 10887,
ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw,
// token 10979,
ves_icall_System_Reflection_RuntimeAssembly_get_EntryPoint_raw,
// token 10989,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw,
// token 10990,
ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw,
// token 11003,
ves_icall_System_Reflection_RuntimeAssembly_get_location_raw,
// token 11004,
ves_icall_System_Reflection_RuntimeAssembly_get_code_base_raw,
// token 11005,
ves_icall_System_Reflection_RuntimeAssembly_get_fullname_raw,
// token 11006,
ves_icall_System_Reflection_RuntimeAssembly_InternalImageRuntimeVersion_raw,
// token 11007,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw,
// token 11008,
ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw,
// token 11009,
ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw,
// token 11016,
ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw,
// token 11032,
ves_icall_RuntimeEventInfo_get_event_info_raw,
// token 11053,
ves_icall_reflection_get_token_raw,
// token 11054,
ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw,
// token 11063,
ves_icall_RuntimeFieldInfo_ResolveType_raw,
// token 11065,
ves_icall_RuntimeFieldInfo_GetParentType_raw,
// token 11072,
ves_icall_RuntimeFieldInfo_GetFieldOffset_raw,
// token 11073,
ves_icall_RuntimeFieldInfo_GetValueInternal_raw,
// token 11076,
ves_icall_RuntimeFieldInfo_SetValueInternal_raw,
// token 11078,
ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw,
// token 11083,
ves_icall_reflection_get_token_raw,
// token 11089,
ves_icall_get_method_info_raw,
// token 11090,
ves_icall_get_method_attributes,
// token 11097,
ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw,
// token 11099,
ves_icall_System_MonoMethodInfo_get_retval_marshal_raw,
// token 11109,
ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw,
// token 11112,
ves_icall_RuntimeMethodInfo_get_name_raw,
// token 11113,
ves_icall_RuntimeMethodInfo_get_base_method_raw,
// token 11114,
ves_icall_reflection_get_token_raw,
// token 11125,
ves_icall_InternalInvoke_raw,
// token 11137,
ves_icall_RuntimeMethodInfo_GetPInvoke_raw,
// token 11143,
ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw,
// token 11144,
ves_icall_RuntimeMethodInfo_GetGenericArguments_raw,
// token 11145,
ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw,
// token 11147,
ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw,
// token 11148,
ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw,
// token 11158,
ves_icall_InternalInvoke_raw,
// token 11177,
ves_icall_reflection_get_token_raw,
// token 11199,
ves_icall_reflection_get_token_raw,
// token 11200,
ves_icall_System_Reflection_RuntimeModule_GetMDStreamVersion_raw,
// token 11201,
ves_icall_System_Reflection_RuntimeModule_InternalGetTypes_raw,
// token 11202,
ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw,
// token 11203,
ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw,
// token 11220,
ves_icall_reflection_get_token_raw,
// token 11225,
ves_icall_RuntimeParameterInfo_GetTypeModifiers_raw,
// token 11230,
ves_icall_RuntimePropertyInfo_get_property_info_raw,
// token 11261,
ves_icall_reflection_get_token_raw,
// token 11262,
ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw,
// token 11798,
ves_icall_AssemblyBuilder_basic_init_raw,
// token 11799,
ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw,
// token 11883,
ves_icall_CustomAttributeBuilder_GetBlob_raw,
// token 11974,
ves_icall_DynamicMethod_create_dynamic_method_raw,
// token 12294,
ves_icall_ModuleBuilder_basic_init_raw,
// token 12295,
ves_icall_ModuleBuilder_set_wrappers_type_raw,
// token 12307,
ves_icall_ModuleBuilder_getUSIndex_raw,
// token 12308,
ves_icall_ModuleBuilder_getToken_raw,
// token 12309,
ves_icall_ModuleBuilder_getMethodToken_raw,
// token 12315,
ves_icall_ModuleBuilder_RegisterToken_raw,
// token 12400,
ves_icall_TypeBuilder_create_runtime_class_raw,
// token 12582,
ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw,
// token 12583,
ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw,
// token 13576,
ves_icall_System_Diagnostics_Debugger_IsAttached_internal,
// token 13577,
ves_icall_System_Diagnostics_Debugger_IsLogging,
// token 13578,
ves_icall_System_Diagnostics_Debugger_Log,
// token 14929,
ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass,
// token 14948,
ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree,
// token 14955,
ves_icall_Mono_RuntimeMarshal_FreeAssemblyName,
// token 14956,
ves_icall_Mono_SafeStringMarshal_StringToUtf8,
// token 14958,
ves_icall_Mono_SafeStringMarshal_GFree,
};
static uint8_t corlib_icall_handles [] = {
0,
1,
1,
0,
1,
1,
1,
0,
1,
0,
1,
1,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
0,
1,
0,
1,
1,
1,
1,
0,
1,
1,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
0,
0,
0,
0,
0,
0,
};
