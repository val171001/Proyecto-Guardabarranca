#! /bin/sh

# Install homebrew
/usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"

# Install aira2
brew install aria2

# Dowload unity torrent
curl --output Unity.torrent https://download.unity3d.com/download_unity/ca4d5af0be6f/Unity-2019.2.1f1.torrent
echo $(ls)

# Dowload unity files using torrent and aria2
aria2c Unity.torrent
echo $(ls)
