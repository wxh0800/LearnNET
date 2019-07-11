import Vue from 'vue'
import Router from 'vue-router'

import Home from '@/views/Home.vue'
import AssignmentList from '@/views/assignments/List.vue'
import AssignmentInspectorReports from '@/views/assignments/InspectorReports.vue'
import AssignmentMetrics from '@/views/assignments/Metrics.vue'

Vue.use(Router)

export default new Router({
	mode: 'history',
	base: process.env.BASE_URL,
	routes: [
		{
			path: '/',
			name: 'Home',
			component: Home
		},
		{
			path: '/search',
			name: 'Search',
			component: () => import(/* webpackChunkName: "search" */ '@/views/Search.vue')
		},
		{
			path: '/assignments',
			name: 'Assignments',
			component: () => import(/* webpackChunkName: "assignments" */ '@/views/assignments/Assignments.vue'),
			children: [
				{
					path: 'list',
					name: 'AssignmentList',
					component: AssignmentList
				},
				{
					path: 'inspector_reports',
					name: 'AssignmentInspectorReports',
					component: AssignmentInspectorReports
				},
				{
					path: 'metrics',
					name: 'AssignmentMetrics',
					component: AssignmentMetrics
				}
			]
		},
		{
			path: '/login',
			name: 'Login',
			component: () => import(/* webpackChunkName: "login" */ '@/views/Login.vue')
		}
	]
})
