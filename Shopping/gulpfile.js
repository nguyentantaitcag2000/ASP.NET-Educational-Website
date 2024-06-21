/// <binding BeforeBuild='default' AfterBuild='default' />
var gulp = require('gulp');
var sass = require('gulp-sass')(require('sass'));

gulp.task('build-css', function () {
    return gulp
        .src('./wwwroot/sass/**/*.scss')
        .pipe(sass().on('error', sass.logError))
        .pipe(gulp.dest('./wwwroot/css'));
});

gulp.task('default', gulp.series('build-css'));
