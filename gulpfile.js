'use strict';

const gulp = require('gulp');
const gulpSass = require('gulp-sass');
const nodeSass = require('node-sass');

const scssFiles = './templates/**/*.scss';

// Compile the SCSS files.
function compileCss(cb) {
    const sass = gulpSass(nodeSass);

    gulp.src(scssFiles)
        .pipe(sass.sync().on('error', sass.logError))
        .pipe(gulp.dest(function (file) {
            return file.base;
        }));

    cb();
}

function scssWatch(cb) {
    gulp.watch(scssFiles, compileCss);
    cb();
}

function defaultTask(cb) {
    compileCss(cb);
    cb();
}

exports.compile = compileCss;
exports.watch = scssWatch;
exports.default = defaultTask;
