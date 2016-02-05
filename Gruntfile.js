module.exports = function(grunt) {


    // Load the plugin that provides the "uglify" task.
    grunt.loadNpmTasks('grunt-contrib-jshint');
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks('grunt-babel');
    grunt.loadNpmTasks('grunt-browserify');

    // Project configuration.
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),
        jshint: {
            src: ['aw/Scripts/**']
        },
        babel: {
            options: {
                sourceMap: true,
                presets: ['es2015'],
            },
            dist: {
                files: {
                    'aw/dist/aw.js': 'aw/dist/aw.js'
                }
            }
        },
        browserify: {
            dist: {
                /*options: {
                    transform: ['dobabel']
                },*/
                files: {
                    'aw/dist/aw.js': 'aw/Scripts/aw.js'
                }
            },
        },
        uglify: {
            options: {
                banner: '/*! <%= pkg.name %> <%= grunt.template.today("yyyy-mm-dd") %> */\n'
            },
            build: {
                src: 'aw/dist/aw.js',
                dest: 'aw/dist/<%= pkg.name %>.min.js'
            }
        },
        watch: {
            scripts: {
                files: ['**/*.js'],
                tasks: ['jshint'],
                options: {
                    spawn: false,
                },
            },
        }
    });


    // Default task(s).
    //grunt.registerTask('dobabel', ['babel']);
    grunt.registerTask('default', ['browserify', 'babel', 'uglify']);
};
