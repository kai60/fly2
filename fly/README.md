
# react-native-fly

## Getting started

`$ npm install react-native-fly --save`

### Mostly automatic installation

`$ react-native link react-native-fly`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-fly` and add `RNFly.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNFly.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNFlyPackage;` to the imports at the top of the file
  - Add `new RNFlyPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-fly'
  	project(':react-native-fly').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-fly/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-fly')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNFly.sln` in `node_modules/react-native-fly/windows/RNFly.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Fly.RNFly;` to the usings at the top of the file
  - Add `new RNFlyPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNFly from 'react-native-fly';

// TODO: What to do with the module?
RNFly;
```
  