#!/bin/sh

result=$( docker inspect -f '{{.State.Running}}' DOTNET-CONT )

if [[ $result == "true" ]]; then
    echo "Container is running"
else 
    echo "Container failed"
fi
