#!/usr/bin/env bash

echo "Arguments for updating:"
echo " - AppCenterId (Microsoft UWP App): $APPCENTER_MICROSOFT"
echo " - AppCenterId (Android App): $APPCENTER_ANDROID"
echo " - AppCenterId (iOS App): $APPCENTER_IOS"
echo " - AppName: $APP_NAME_REPLACE"

# Updating UserSettings
SettingsFile=$APPCENTER_SOURCE_DIRECTORY/Client/PITCSurveyApp/PITCSurveyApp/PITCSurveyApp/Helpers/UserSettings.cs

sed -i '' "s/APPCENTER_MICROSOFT/$APPCENTER_MICROSOFT/g" $SettingsFile
sed -i '' "s/APPCENTER_MICROSOFT/$APPCENTER_ANDROID/g" $SettingsFile
sed -i '' "s/APPCENTER_MICROSOFT/$APPCENTER_IOS/g" $SettingsFile

# Print out file for reference
cat $SettingsFile

# Updating app name
CloudServiceFile=$APPCENTER_SOURCE_DIRECTORY/Client/PITCSurveyApp/PITCSurveyApp/PITCSurveyApp/Services/SurveyCloudService.cs
sed -i '' "s/APP_NAME_REPLACE/$APP_NAME_REPLACE/g" $CloudServiceFile

# Print out file for reference
cat $CloudServiceFile

echo "Updated settings!"
