#! /bin/sh

echo "Running playmode tests for ${PROJECT_NAME}"

# Run unity tests on playmode
/Applications/Unity/Unity.app/Contents/MacOS/Unity \
	-batchmode \
	-nographics \
	-silent-crashes \
	-projectPath "$(pwd)" \
	-runTests \
    -testPlatform playmode \
	-testResults $(pwd)/Logs/TestResults.xml \
	-quit


TEST_SUCCESS=$?
echo "Test results"
cat $(pwd)/Logs/TestResults.xml
# Abort on failed tests
if [ $TEST_SUCCESS -ne 0 ]; then
    echo "Tests failed"
    exit $TEST_SUCCESS
fi

# Build APK
