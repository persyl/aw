module.exports = function(grunt) {

  // Project configuration.
  grunt.initConfig({
    pkg: grunt.file.readJSON('package.json'),
    jshint: {
		src: ['aw/Scripts/**']
	},
	uglify: {
      options: {
        banner: '/*! <%= pkg.name %> <%= grunt.template.today("yyyy-mm-dd") %> */\n'
      },
      build: {
        src: 'aw/Scripts/*.js',
        dest: 'aw/Scripts/dist/<%= pkg.name %>.min.js'
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

  // Load the plugin that provides the "uglify" task.
  grunt.loadNpmTasks('grunt-contrib-jshint');
  grunt.loadNpmTasks('grunt-contrib-uglify');
  grunt.loadNpmTasks('grunt-contrib-watch');

  // Default task(s).
  grunt.registerTask('default', ['uglify']);
};