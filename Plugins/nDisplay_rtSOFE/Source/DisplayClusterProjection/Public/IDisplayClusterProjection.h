// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

#pragma once

#include "Modules/ModuleManager.h"
#include "Modules/ModuleInterface.h"

class IDisplayClusterProjectionPolicyFactory;


class IDisplayClusterProjection : public IModuleInterface
{
public:
	static constexpr auto ModuleName = TEXT("DisplayClusterProjection");

public:
	virtual ~IDisplayClusterProjection()
	{ }

public:
	/**
	 * Singleton-like access to this module's interface.  This is just for convenience!
	 * Beware of calling this during the shutdown phase, though.  Your module might have been unloaded already.
	 *
	 * @return Returns singleton instance, loading the module on demand if needed
	 */
	static inline IDisplayClusterProjection& Get()
	{
		return FModuleManager::LoadModuleChecked<IDisplayClusterProjection>(IDisplayClusterProjection::ModuleName);
	}

	/**
	 * Checks to see if this module is loaded and ready.  It is only valid to call Get() if IsAvailable() returns true.
	 *
	 * @return True if the module is loaded and ready to use
	 */
	static inline bool IsAvailable()
	{
		return FModuleManager::Get().IsModuleLoaded(IDisplayClusterProjection::ModuleName);
	}

	/**
	* Returns supported projection types
	*
	* @param OutProjectionTypes - (out) Array of supported projection types
	*/
	virtual void GetSupportedProjectionTypes(TArray<FString>& OutProjectionTypes) = 0;

	/**
	* Returns specified projection factory
	*
	* @param InProjectionType - Projection type
	*
	* @return - Projection policy factory of requested type, null if not available
	*/
	virtual TSharedPtr<IDisplayClusterProjectionPolicyFactory> GetProjectionFactory(const FString& InProjectionType) = 0;
};
