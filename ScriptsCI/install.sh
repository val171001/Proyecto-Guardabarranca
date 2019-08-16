#! /bin/sh

function after_task() {
    if [ $1 -ne 0 ]; then
        echo $2
        exit $1
    fi
}

# Install homebrew
echo "Installing Homebrew"
/usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"
after_task $? "Homebrew downlad failed"

# Install aira2
echo "Installing aria2"
brew install aria2
after_task $? "Aria2 install failed"

# Dowload unity torrent
echo "Dowloading Unity Torrent"
curl --output Unity.torrent $UNITY_TORRENT_URL
after_task $? "Unity torrent downlad failed"

# Dowload macos unity files using torrent and aria2
echo "Downloading Unity with andorid support"
aria2c --seed-time=0 --select-file=3,4 Unity.torrent
after_task $? "Unity downlad failed"

# Install unity and add android support
echo "Installing unity"
sudo installer -dumplog -package ./Unity-2019.2.1f1/MacOSX/Unity.pkg -target /
echo "Adding android support"
sudo installer -dumplog -package ./Unity-2019.2.1f1/MacOSX/UnitySetup-Android-Support-for-Editor.pkg -target /
