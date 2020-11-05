/************************************************************************/
/* UMBRA TOOLS                                                          */
/* Maxwell - Axel Clerget   											*/
/************************************************************************/

#include "StateMachineFactory.h"
#include "StateMachineBlueprint.h"
#include "StateMachineBlueprintGeneratedClass.h"
#include "StateMachine.h"
#include "Engine/Blueprint.h"
#include "Kismet2/KismetEditorUtilities.h"

UStateMachineFactory::UStateMachineFactory(const FObjectInitializer& ObjectInitializer)
	: Super(ObjectInitializer)
{
	bCreateNew = true;
	bEditAfterNew = true;
	SupportedClass = UStateMachineBlueprint::StaticClass();
	ParentClass = UStateMachine::StaticClass();
}

UObject* UStateMachineFactory::FactoryCreateNew(UClass* Class, UObject* InParent, FName Name, EObjectFlags Flags, UObject* Context, FFeedbackContext* Warn, FName CallingContext)
{
	UStateMachineBlueprint* StateMachineBlueprint = CastChecked<UStateMachineBlueprint>(FKismetEditorUtilities::CreateBlueprint(ParentClass, InParent, Name, BPTYPE_Normal, UStateMachineBlueprint::StaticClass(), UStateMachineBlueprintGeneratedClass::StaticClass(), CallingContext));

	return StateMachineBlueprint;
}

UObject* UStateMachineFactory::FactoryCreateNew(UClass* Class, UObject* InParent, FName Name, EObjectFlags Flags, UObject* Context, FFeedbackContext* Warn)
{
	return FactoryCreateNew(Class, InParent, Name, Flags, Context, Warn, NAME_None);
}

FName UStateMachineFactory::GetNewAssetThumbnailOverride() const
{
	return TEXT("ClassThumbnail.StateMachineBlueprint");
}
