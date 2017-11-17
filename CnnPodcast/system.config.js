/* System configuration for Angular samples
    * Adjust as necessary for your application needs.
*/
            (function (global) {
                //System.config({
                    // map tells the System loader where to look for things
                var map = {
                    // our app is within the app folder
                    'app': '/app',
                    // angular bundles
                    '@angular': 'node_modules/@angular',
                    'angular-in-memory-web-api': 'node_modules/angular-in-memory-web-api',
                    'rxjs': '/node_modules/rxjs'
                    /*'@angular/common': 'npm:@angular/common/bundles/common.umd.js',
                    '@angular/compiler': 'npm:@angular/compiler/bundles/compiler.umd.js',
                    '@angular/platform-browser': 'npm:@angular/platform-browser/bundles/platform-browser.umd.js',
                    '@angular/platform-browser-dynamic': 'npm:@angular/platform-browser-dynamic/bundles/platform-browser-dynamic.umd.js',
                    '@angular/http': 'npm:@angular/http/bundles/http.umd.js',
                    '@angular/router': 'npm:@angular/router/bundles/router.umd.js',
                    '@angular/forms': 'npm:@angular/forms/bundles/forms.umd.js',
                    // other libraries
                    'rxjs': 'npm:rxjs',
                    'angular-in-memory-web-api': 'npm:angular-in-memory-web-api/bundles/in-memory-web-api.umd.js',*/
                },
                    // packages tells the System loader how to load when no filename and/or no extension
                    packages = {
                        'app': {
                            main: './main.js',
                            defaultExtension: 'js'
                        },
                        'angular-in-memory-web-api': {
                            main: './index.js',
                            defaultExtension: 'js'
                        },
                        'rxjs': {
                            defaultExtension: 'js'
                        }
                    },
                    ngPackageNames = [
                        'common',
                        'compiler',
                        'core',
                        'http',
                        'platform-browser',
                        'platform-browser-dynamic',
                        'router',
                        'forms'
                    ];
                    function packUmd(pkgName) {
                        packages['@angular/' + pkgName] = { main: '/bundles/' + pkgName + '.umd.js', defaultExtension: 'js' };
                    }
                    ngPackageNames.forEach(packUmd);

                    var config = {
                        map: map,
                        packages: packages
                    };

                    System.config(config);

                //});
            })(this);