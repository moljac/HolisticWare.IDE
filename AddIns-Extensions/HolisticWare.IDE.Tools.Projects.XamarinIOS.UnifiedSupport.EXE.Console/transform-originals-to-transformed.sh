#!/bin/bash

PATH_TANSFORMER=./Xamarin.iOS.UnifiedSupportTransformer.Console.exe

ls -al transformed/
rm -fr transformed/*

mono $PATH_TANSFORMER \
		-i originals/MonoVersal.MarkDown.MarkDownDeep.XI.csproj \
		-o transformed/

ls -al transformed/
rm -fr transformed/*

mono $PATH_TANSFORMER \
		-i originals/MonoVersal.MarkDown.MarkDownDeep.XI.csproj \
		-o transformed/

ls -al transformed/
rm -fr transformed/*

mono $PATH_TANSFORMER \
		-i originals/ \
		-o transformed/

